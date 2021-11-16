using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    //Gameplay
    private float worldChunkSpawnZ;
    private Queue<WorldChunk> activeWorldChunks = new Queue<WorldChunk>();
    private List<WorldChunk> worldChunksPool = new List<WorldChunk>();


    //Configurable fields
    [SerializeField] private int firstWorldChunkSpawnPosition = 5;
    [SerializeField] private int worldChunksOnScreen = 5;
    [SerializeField] private float despawnDistance = 5f;

    [SerializeField] private List<GameObject> worldChunkPrefabs;
    [SerializeField] private Transform cameraTransform;


    private void Awake()
    {
        ResetWorld();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Checking if worldchunk list is has prefabs
        if (worldChunkPrefabs.Count == 0)
        {
            Debug.Log("No worldChunks in the prefab List");
            return;
        }

        //Assign cameraTransform
        if (!cameraTransform)
        {
            cameraTransform = Camera.main.transform;
            Debug.Log("Camera transform assigned automatically to main camera!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScanPosition();
    }

    private void ScanPosition()
    {
        float cameraPositionZ = cameraTransform.position.z;

        //.Peek() == [activeWorldChunks.length - 1] --> Takes the lasdt element in the queue.
        WorldChunk lastChunk = activeWorldChunks.Peek(); 

        if (cameraPositionZ >= lastChunk.transform.position.z + lastChunk.worldChunkLength + despawnDistance)
        {
            SpawnNewWorldChunk();
            DeleteLastWorldChunk();
        }
    }

    private void SpawnNewWorldChunk()
    {
        //Getting a random index from worldChunksPrefab list
        int randomIndex = Random.Range(0, worldChunkPrefabs.Count);

        //Does it already exist in the pool?
        WorldChunk worldChunk = worldChunksPool.Find(spawnWorldChunk => !spawnWorldChunk.gameObject.activeSelf && spawnWorldChunk.name == (worldChunkPrefabs[randomIndex].name + "(Clone)"));

        //Create a worldChunk if theres none to reuse
        if (!worldChunk)
        {
            GameObject createWorldChunk = Instantiate(worldChunkPrefabs[randomIndex], transform);
            worldChunk = createWorldChunk.GetComponent<WorldChunk>();
        }

        //Place the worldchunk, and set it active.
        worldChunk.gameObject.transform.position = new Vector3(0, 0, worldChunkSpawnZ);
        worldChunkSpawnZ += worldChunk.worldChunkLength;

        //Store the value to reuse in the pool
        activeWorldChunks.Enqueue(worldChunk);
        worldChunk.ShowWoprldChunk();
    }

    private void DeleteLastWorldChunk()
    { 
        //Dequeue() --> removes first item from the list and stores it 
        WorldChunk worldChunk = activeWorldChunks.Dequeue();
        worldChunk.HideWorldChunk();
        worldChunksPool.Add(worldChunk);
    }

    private void ResetWorld()
    {
        //REset the worldChunkSpawn z
        worldChunkSpawnZ = firstWorldChunkSpawnPosition;

        for (int i = activeWorldChunks.Count; i !=0; i--)
        {
            DeleteLastWorldChunk();
        }
        for (int i = 0; i < worldChunksOnScreen; i++)
        {
            SpawnNewWorldChunk();
        }
    }
}
