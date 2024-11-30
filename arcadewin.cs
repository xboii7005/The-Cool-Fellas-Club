using UnityEngine;
using TMPro;

public class arcadewin : MonoBehaviour
{
    public GameObject player;        
    public GameObject spawner;       
    public GameObject object1;       
    public GameObject object2;       
    public TextMeshProUGUI scoreText; 

    public int targetScore = 100;    
    private bool hasTriggered = false; 

    void Update()
    {
        if (scoreText == null)
        {
            Debug.LogError("ScoreText is not assigned!");
            return;
        }

        
        int currentScore = ParseScoreFromText(scoreText.text);

        
        if (currentScore >= targetScore && !hasTriggered)
        {
            hasTriggered = true;
            HandleScoreReached();
        }
    }

    private int ParseScoreFromText(string text)
    {
        
        if (text.StartsWith("Score:"))
        {
            string scoreString = text.Substring(6).Trim(); 
            if (int.TryParse(scoreString, out int score))
            {
                return score; 
            }
        }
        return 0; 
    }

    private void HandleScoreReached()
    {
        
        if (player != null) player.SetActive(false);
        if (spawner != null) spawner.SetActive(false);

        
        if (object1 != null) object1.SetActive(true);
        if (object2 != null) object2.SetActive(true);

        Debug.Log("Target score reached! Player and spawner deactivated, objects activated.");
    }
}

