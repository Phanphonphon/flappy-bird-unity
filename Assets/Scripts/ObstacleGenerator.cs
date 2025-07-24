using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject pipeTopPrefab;
    public GameObject pipeBottomPrefab;
    public float spawnInterval = 2f;
    public float minY = -2f;
    public float maxY = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        float yOffset = Random.Range(minY, maxY);

        Vector3 topPos = new Vector3(transform.position.x, yOffset + 4.5f, 0);
        Vector3 bottomPos = new Vector3(transform.position.x, yOffset - 4.5f, 0);

        Instantiate(pipeTopPrefab, topPos, Quaternion.identity);
        Instantiate(pipeBottomPrefab, bottomPos, Quaternion.identity);
    }
}
