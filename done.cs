using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class done : MonoBehaviour
{
    public GameObject labreset;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("toxic")) 
        {
            
            labreset.SetActive(true);
            Destroy(gameObject);

        }
        if(other.CompareTag("bar"))
        {
            Destroy(gameObject);
        }
        
    }
}
