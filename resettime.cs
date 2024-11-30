using UnityEngine;

public class RestTime : MonoBehaviour
{
    public GameObject objectToActivate; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("car"))
        {
            
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }

            
            Destroy(gameObject);
        }
    }
}

