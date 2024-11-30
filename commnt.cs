using UnityEngine;

public class commnt: MonoBehaviour
{
    public AudioSource audioSource;     
    public GameObject player;            

   

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
           
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
                gameObject.SetActive(false);
            }

           
        }
    }

   
    
}
