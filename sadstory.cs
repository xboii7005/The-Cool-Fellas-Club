using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sadstory : MonoBehaviour
{
    public GameObject activationObject; 
    public AudioSource[] audioSequence; 
    public string sceneToLoad; 
    private bool isPlayerNearby = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (activationObject != null)
                activationObject.SetActive(true); 
            isPlayerNearby = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (activationObject != null)
                activationObject.SetActive(false); 
            isPlayerNearby = false; 
        }
    }

    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(PlayAudioSequenceAndLoadScene());
        }
    }

    private IEnumerator PlayAudioSequenceAndLoadScene()
    {
        
        isPlayerNearby = false;

        foreach (AudioSource audio in audioSequence)
        {
            if (audio != null && audio.clip != null)
            {
                audio.Play();
                yield return new WaitForSeconds(audio.clip.length); 
            }
        }

       
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}


