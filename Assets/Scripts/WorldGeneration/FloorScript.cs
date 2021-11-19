using UnityEngine;

public class FloorScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Material material;
    public float offsetSpeed = 0.2f;

    private void Update()
    {
        transform.position = new Vector3(0, 0, player.transform.position.z);
        material.SetVector("_offset", new Vector2(0, -transform.position.z * offsetSpeed));
    }
}
