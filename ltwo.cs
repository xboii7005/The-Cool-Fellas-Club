using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltwo : MonoBehaviour
{
    public GameObject eto;
    public GameObject[] sequenceObjects;  
    public AudioSource[] sequenceAudioSources;  
    public GameObject requiredObject;  
    public float objectActiveTime = 5f;  
    public float audioDelayTime = 2f;  
    public GameObject player;  
    private bool isPlayerNearby = false;  
    public float teleportXPosition;
    public GameObject dessertbg;
    public GameObject worldbg;
    public GameObject canjump;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            eto.SetActive(true);
            isPlayerNearby = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            eto.SetActive(false);
            isPlayerNearby = false;
        }
    }

    private void Update()
    {
        
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E) && requiredObject.activeInHierarchy)
        {
            eto.SetActive(false);
            StartCoroutine(ActivateSequence());
        }
    }

    private IEnumerator ActivateSequence()
    {
        
        move playerMovement = player.GetComponent<move>();
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }

       

       
        for (int i = 0; i < sequenceObjects.Length; i++)
        {
            GameObject obj = sequenceObjects[i];
            AudioSource audioSource = sequenceAudioSources[i];

            if(obj != null)
            {
                obj.SetActive(true);
            }
            

          
            yield return new WaitForSeconds(objectActiveTime);

            
            obj.SetActive(false);

           
            yield return new WaitForSeconds(audioDelayTime);

           
            if (audioSource != null)
            {
                audioSource.Play();
            }
           
            
        }

        
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }

        
        gameObject.SetActive(false);
        requiredObject.SetActive(false);
        Vector3 playerPosition = player.transform.position; 
        playerPosition.x = teleportXPosition;               
        player.transform.position = playerPosition;
        worldbg.SetActive(false);
        dessertbg.SetActive(true);
        canjump.SetActive(true);
        player.transform.localScale = new Vector3(Mathf.Abs(2.5f), 2.5f, player.transform.localScale.z);

    }
}
