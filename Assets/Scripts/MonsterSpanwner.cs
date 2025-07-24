using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float spawnInterval = 5f;
    public float minY = -2f;
    public float maxY = 2f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnMonster();
        }
    }

    void SpawnMonster()
    {
        Debug.Log("Spawn monster!");
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(Camera.main.transform.position.x + 8f, randomY, 0);
        Instantiate(monsterPrefab, spawnPos, Quaternion.identity);
    }
}
