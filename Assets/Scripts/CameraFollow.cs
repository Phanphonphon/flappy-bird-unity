using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offsetX = 2f;

    void Update()
    {
        if (player != null && transform.position.x < player.position.x + offsetX)
        {
            transform.position = new Vector3(player.position.x + offsetX, 0, -10f);
        }
    }
}
