using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalboss : MonoBehaviour
{
    public GameObject object1; 
    public GameObject object2; 
    public GameObject player;  
    public float targetXPosition = 0f;
    public GameObject oldbg;
    public GameObject sco; 
    public GameObject l2;

    void Update()
    {
        
        if (object1.activeInHierarchy && object2.activeInHierarchy && Input.GetKeyDown(KeyCode.E))
        {
            PerformActions();
        }
    }

    private void PerformActions()
    {
        
        object1.SetActive(false);
        object2.SetActive(false);
        oldbg.SetActive(true);
        sco.SetActive(false);
        l2.SetActive(true);

        
        Vector3 playerPosition = player.transform.position;
        player.transform.position = new Vector3(targetXPosition, playerPosition.y, playerPosition.z);

        
        SpriteRenderer playerRenderer = player.GetComponent<SpriteRenderer>();
        if (playerRenderer != null)
        {
            playerRenderer.sortingOrder = 5; 
        }

        
        BoxCollider2D playerCollider = player.GetComponent<BoxCollider2D>();
        if (playerCollider != null)
        {
            playerCollider.isTrigger = false;
        }

        
        Rigidbody2D playerRigidbody = player.GetComponent<Rigidbody2D>();
        if (playerRigidbody != null)
        {
            playerRigidbody.gravityScale = 1;

            
            playerRigidbody.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
            
            playerRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        Debug.Log("Actions performed successfully.");
    }
}
