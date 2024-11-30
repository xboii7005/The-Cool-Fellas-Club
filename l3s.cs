using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3s : MonoBehaviour
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
    public GameObject worldbg;
    private Rigidbody2D playerRb;
    private SpriteRenderer playerSpriteRenderer;
    private BoxCollider2D playerBoxCollider;
    public GameObject score;
    public GameObject Player2;
    public GameObject spawn;
    public GameObject carmanage;
    private void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
        playerBoxCollider = player.GetComponent<BoxCollider2D>();

        if (playerRb == null) Debug.LogError("Player is missing a Rigidbody2D component!");
        if (playerSpriteRenderer == null) Debug.LogError("Player is missing a SpriteRenderer component!");
        if (playerBoxCollider == null) Debug.LogError("Player is missing a BoxCollider2D component!");
    }

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
        playerRb.velocity = Vector2.zero; 
        playerRb.gravityScale = 0;
        playerBoxCollider.isTrigger = true;
        playerSpriteRenderer.sortingOrder = -1; 
        playerBoxCollider.isTrigger = true;
        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
        score.SetActive(true);
        Player2.SetActive(true);
        spawn.SetActive(true);
        carmanage.SetActive(true);

    }
}
