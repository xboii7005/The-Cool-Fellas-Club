using UnityEngine;
using TMPro; 

public class carmanage : MonoBehaviour
{
    public TextMeshProUGUI timerText; 
    public GameObject triggerObject; 
    public GameObject[] objectsToDeactivate; 
    public GameObject[] objectsToActivate;   
    public float timerDuration = 120f; 

    private float currentTime;
    private bool isTimerRunning = false;

    void Start()
    {
        
        currentTime = timerDuration;
        UpdateTimerDisplay();
        isTimerRunning = true; 
    }

    void Update()
    {
        
        if (triggerObject != null && triggerObject.activeInHierarchy)
        {
            ResetTimer();
        }

       
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

           
            if (currentTime <= 0)
            {
                currentTime = 0;
                isTimerRunning = false;

                
                HandleTimerEnd();
            }

            
            UpdateTimerDisplay();
        }
    }

    private void UpdateTimerDisplay()
    {
        
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void HandleTimerEnd()
    {
        
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null) obj.SetActive(false);
        }

        
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null) obj.SetActive(true);
        }
    }

    public void ResetTimer()
    {
        
        currentTime = timerDuration;
        isTimerRunning = true;

        
        triggerObject.SetActive(false);
    }
}

