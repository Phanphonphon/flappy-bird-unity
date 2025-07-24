// MonsterMove.cs
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
