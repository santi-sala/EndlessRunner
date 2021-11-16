using UnityEngine;

public class WorldChunk : MonoBehaviour
{
    public float worldChunkLength;

    public WorldChunk ShowWoprldChunk()
    {
        gameObject.SetActive(true);
        return this;
    }

    public WorldChunk HideWorldChunk()
    {
        gameObject.SetActive(false);
        return this;
    }
}
