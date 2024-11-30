using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    public GameObject player; 
    public GameObject requiredObject; 
    public float teleportX; 
    public KeyCode interactKey = KeyCode.E; 

    private Rigidbody2D playerRb; 
    private SpriteRenderer playerSpriteRenderer; 
    private BoxCollider2D playerBoxCollider; 
    public GameObject eto;
    public GameObject spaceship;
    public GameObject wrldbg;
    public GameObject spacebg;
    public GameObject spawner;
    public GameObject txt;

    private void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player GameObject is not assigned!");
            return;
        }

        
        playerRb = player.GetComponent<Rigidbody2D>();
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
        playerBoxCollider = player.GetComponent<BoxCollider2D>();

        if (playerRb == null) Debug.LogError("Player is missing a Rigidbody2D component!");
        if (playerSpriteRenderer == null) Debug.LogError("Player is missing a SpriteRenderer component!");
        if (playerBoxCollider == null) Debug.LogError("Player is missing a BoxCollider2D component!");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        eto.SetActive(true);
        
        if (other.gameObject == player && Input.GetKeyDown(interactKey))
        {
            
            if (requiredObject != null && requiredObject.activeSelf)
            {
                ModifyPlayer();
                eto.SetActive(false);
                spaceship.SetActive(true);
                spacebg.SetActive(true);
                wrldbg.SetActive(false);
                txt.SetActive(true);
                requiredObject.SetActive(false);
                spawner.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
    

    private void ModifyPlayer()
    {
        if (player == null || playerRb == null || playerSpriteRenderer == null || playerBoxCollider == null)
        {
            Debug.LogError("Player or its components are not properly assigned!");
            return;
        }

       
        player.transform.position = new Vector3(teleportX, player.transform.position.y, player.transform.position.z);

       
        playerRb.velocity = Vector2.zero; 
        playerRb.gravityScale = 0;
        playerBoxCollider.isTrigger = true;
        playerSpriteRenderer.sortingOrder = -1; 
        playerBoxCollider.isTrigger = true;
        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;


        Debug.Log("Player properties modified.");
    }
}
