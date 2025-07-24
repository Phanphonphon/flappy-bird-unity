using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            Destroy(collision.gameObject); // Xoá quái
            Destroy(gameObject); // Xoá đạn
        }
    }
}
