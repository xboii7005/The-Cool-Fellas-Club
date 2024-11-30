using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exito : MonoBehaviour
{
    public GameObject Eto;
    public float teleportXPosition;
    public GameObject player;
    public GameObject task21;
    public GameObject task22;
    public GameObject wrldbg;
    public GameObject arcbg;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            
            
            Eto.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            
            Eto.SetActive(false);
        }
    }

    private void Update()
    {
        
        if (  task21 != null && Input.GetKeyDown(KeyCode.E) && Eto.activeInHierarchy )
        {
            
            Vector3 playerPosition = player.transform.position; 
            playerPosition.x = teleportXPosition;               
            player.transform.position = playerPosition;
            Destroy(task21);
            task22.SetActive(true);
            wrldbg.SetActive(false);
            arcbg.SetActive(true);
            player.transform.localScale = new Vector3(2.5f, 2.5f, 1f);
        }
    }
}
