using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitarcade : MonoBehaviour
{
    public GameObject task24;
    public GameObject task23;
    public GameObject player;
    public float teleportXPosition;
    public GameObject arcbg;
    public GameObject wrldbg;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && task23.activeInHierarchy)
        {
            Vector3 playerPosition = player.transform.position; 
            playerPosition.x = teleportXPosition;               
            player.transform.position = playerPosition;
            task23.SetActive(false);
            task24.SetActive(true);
            arcbg.SetActive(false);
            wrldbg.SetActive(true);
            player.transform.localScale = new Vector3(Mathf.Abs(1.3f), 1.3f, player.transform.localScale.z);

            
            
            
        }
    }
}
