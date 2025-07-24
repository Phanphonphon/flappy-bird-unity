using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flapForce = 6f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
        }
    }
}
