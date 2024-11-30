using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;        
    public LayerMask groundLayer;      
    public Transform groundCheck;      
    public float groundCheckRadius = 0.2f; 
    public GameObject jumpActivator;   

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && jumpActivator.activeInHierarchy)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
    }

    void OnDrawGizmosSelected()
    {
        
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}

