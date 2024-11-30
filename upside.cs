using UnityEngine;

public class upside : MonoBehaviour
{
    public Transform player;           
    public Transform teleportLocation; 
    public float fallSpeed = 5f;       
    private bool isFalling = false;   

    void Update()
    {
        
        if (isFalling)
        {
            transform.position += Vector3.down * fallSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("Player"))
        {
            isFalling = true;
        }

       
        if (isFalling && other.CompareTag("Player"))
        {
            
            player.position = teleportLocation.position;
            Debug.Log("Player hit by the spike and teleported!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isFalling = false; 
            Debug.Log("Spike hit the ground.");
        }
    }
}

