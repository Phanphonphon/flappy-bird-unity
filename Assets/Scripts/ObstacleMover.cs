using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float destroyX = -15f;

    void Update()
    {
        // Di chuyển pipe sang trái
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Nếu vượt quá màn hình thì xóa đi
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
