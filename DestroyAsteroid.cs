using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject); 
        }
    }
}
