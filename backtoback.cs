using UnityEngine;
using UnityEngine.SceneManagement; 

public class backtoback : MonoBehaviour
{
    public GameObject targetObject;
    public string sceneToLoad; 
    private bool isPlayerInside = false; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            if (targetObject != null)
            {
                targetObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false; 
            if (targetObject != null)
            {
                targetObject.SetActive(false); 
            }
        }
    }

    private void Update()
    {
        
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                SceneManager.LoadScene(sceneToLoad); 
            }
            else
            {
                Debug.LogWarning("No scene specified to load.");
            }
        }
    }
}
