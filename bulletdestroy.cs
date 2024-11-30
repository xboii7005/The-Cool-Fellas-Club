using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject); 
        }
    }
}
