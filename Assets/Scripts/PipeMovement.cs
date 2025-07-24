using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float destroyX = -15f; // Khi ra khỏi màn hình bên trái thì xoá

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
