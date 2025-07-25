using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player trúng đạn!");
            // TODO: Gây sát thương hoặc restart game
            Destroy(gameObject);
        }
        else if (other.CompareTag("Monster"))
        {
            Debug.Log("Monster bị tiêu diệt!");
            KillManager.Instance.AddKill(); // ✅ Gọi tăng kill
            Destroy(other.gameObject);      // Xoá quái
            Destroy(gameObject);            // Xoá đạn
        }
    }
}