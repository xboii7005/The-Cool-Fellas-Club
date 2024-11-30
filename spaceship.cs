using UnityEngine;

public class spaceship : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody2D rb; 
    private Vector2 movement; 

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody2D component found on this GameObject!");
        }
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");   

        
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        
        rb.velocity = movement * moveSpeed;
    }
}

