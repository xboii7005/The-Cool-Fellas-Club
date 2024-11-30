using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform targetLocation; 
    public GameObject player;       

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        player.transform.position = targetLocation.position;
        Debug.Log("Player teleported to target location!");
    }
}

}

