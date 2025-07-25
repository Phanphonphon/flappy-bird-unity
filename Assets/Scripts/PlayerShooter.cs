using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 8f;
    public float fireCooldown = 0.3f;

    public AudioClip shootSound; // <-- Th�m d?ng n�y
    private AudioSource audioSource; // <-- V� d?ng n�y

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

        // Ph�t �m thanh b?n �?n
        if (shootSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(shootSound);
        }
    }
}
