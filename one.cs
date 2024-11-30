using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour
{
    public GameObject addone;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            

            addone.SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
