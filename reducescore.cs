using UnityEngine;
using TMPro;

public class reducescore : MonoBehaviour
{
    public GameObject red;
    
    public string asteroidTag = "Asteroid";

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag(asteroidTag))
        {
            red.SetActive(true);
            Destroy(collision.gameObject);

            Debug.Log("Asteroid destroyed! Score updated.");
        }
    }

  
}

