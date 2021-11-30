using UnityEngine;

public class WorldChunk : MonoBehaviour
{
    public float worldChunkLength;

    public WorldChunk ShowWoprldChunk()
    {
        // Respawning the coins
        transform.gameObject.BroadcastMessage("OnShowWorldChunk", SendMessageOptions.DontRequireReceiver);

        gameObject.SetActive(true);
        return this;
    }

    public WorldChunk HideWorldChunk()
    {
        gameObject.SetActive(false);
        return this;
    }
}
