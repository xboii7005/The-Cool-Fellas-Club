using UnityEngine;

public class jeez : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("descar"))
        {
            

            
            Destroy(gameObject);
        }
    }
}
