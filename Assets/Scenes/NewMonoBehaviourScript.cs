using UnityEngine;

public class Monster : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -15f)  // ngoài màn th? xóa
        {
            Destroy(gameObject);
        }
    }
}