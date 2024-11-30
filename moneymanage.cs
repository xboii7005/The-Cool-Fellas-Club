using UnityEngine;
using TMPro;

public class moneymanage : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public GameObject monitoredObject; 
    public GameObject[] objectsToDeactivate; 
    public GameObject objectToActivate; 

    private int score = 0;
    private bool hasTriggered = false; 

    private void Update()
    {
        
        if (monitoredObject.activeInHierarchy && !hasTriggered)
        {
            IncrementScore();
            monitoredObject.SetActive(false); 
        }

        
        if (score >= 30 && !hasTriggered)
        {
            TriggerEvent(); 
        }
    }

    private void IncrementScore()
    {
        score += 1;
        UpdateScoreText(); 
        hasTriggered = true; 

        
        StartCoroutine(ResetTriggerWhenInactive());
    }

    private System.Collections.IEnumerator ResetTriggerWhenInactive()
    {
        
        yield return new WaitUntil(() => !monitoredObject.activeInHierarchy);
        hasTriggered = false; 
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; 
    }

    private void TriggerEvent()
    {
        
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }

        
    }
}
