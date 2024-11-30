using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f;          
    private Rigidbody2D rb;          
    private Animator animator;       
    private SpriteRenderer spriteRenderer; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        
        animator.SetBool("walk", moveInput != 0);

        
        if (moveInput > 0)
        {
            spriteRenderer.flipX = false; 
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
