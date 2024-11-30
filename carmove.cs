using UnityEngine;

public class carmove : MonoBehaviour
{
    public float speed = 5f; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal"); 
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); 
    }
}

