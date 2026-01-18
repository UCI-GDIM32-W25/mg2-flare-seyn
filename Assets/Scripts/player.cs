using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpForce = 6f;
    public LayerMask groundLayer;
    public Transform groundCheck;   
    public float groundCheckRadius = 0.15f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   void Update()
{
    isGrounded = Physics2D.Raycast(
        groundCheck.position,
        Vector2.down,
        0.1f,
        groundLayer
    );

    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}

private void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Coin"))
    {
        GameManager.Instance.AddPoint(1);
        Destroy(other.gameObject);
    }
}

    void OnDrawGizmosSelected()
    {
        if (groundCheck == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
