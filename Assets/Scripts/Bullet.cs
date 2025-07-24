using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player trúng đạn!");
            // TODO: Gây sát thương hoặc restart game
            Destroy(gameObject); // Xoá đạn sau khi trúng
        }
    }
}
