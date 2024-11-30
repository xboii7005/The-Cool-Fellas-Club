using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("ground"))
        {
            

            
            Destroy(gameObject);
        }
    }
}
