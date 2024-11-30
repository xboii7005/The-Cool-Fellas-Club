using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeeyee : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("skeyee")) 
        {
            
            Destroy(other.gameObject); 
            Destroy(gameObject);

        }
        
    }
}
