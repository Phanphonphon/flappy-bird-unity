using UnityEngine;

public class MonsterShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireInterval = 2f;
    public float bulletSpeed = 5f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {
            timer = 0f;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.left * bulletSpeed; 
        }
    }
}
