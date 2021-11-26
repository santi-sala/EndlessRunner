using UnityEngine;

public enum VirtualCameras
{
    Init = 0,
    Game = 1,
    Shop = 2,
    Respawn = 3

}

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance { get { return instance; } }
    private static GameManager instance;

    public TiagoMotor gameMotor;
    public WorldGeneration worldGeneration;
    public ScenaryGeneration scenaryGeneration;
    public GameObject[] cameras;


    private GameState state;


    private void Awake()
    {
        instance = this;
        state = GetComponent<GameStateInt>();
        state.Construct();
    }

    private void Update()
    {
        state.UpdateState();
    }

    public void ChangeState(GameState newState)
    {
        state.Destruct();
        state = newState;
        state.Construct();
    }

    public void ChangeCamera(VirtualCameras virtualcam)
    {
        foreach (var cam in cameras)
        {
            cam.SetActive(false);
        }

        cameras[(int)virtualcam].SetActive(true);
    }
}
