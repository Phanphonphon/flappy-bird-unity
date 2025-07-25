using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 8f;
    public float fireCooldown = 0.3f;

    public AudioClip shootSound; // <-- Thêm d?ng này
    private AudioSource audioSource; // <-- Và d?ng này

    private float nextFireTime = 0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // <-- L?y AudioSource t? GameObject
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireCooldown;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.right * bulletSpeed;

        // Phát âm thanh b?n ð?n
        if (shootSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(shootSound);
        }
    }
}
