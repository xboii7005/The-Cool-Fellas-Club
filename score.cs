using UnityEngine;
using TMPro; 

public class Scorecount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  
    public int score = 0;             

    void Start()
    {
        UpdateScoreText();  
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            
            Destroy(collision.gameObject);

            
            AddScore(5);
        }

        
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            Destroy(collision.gameObject);
        }
    }

    
    private void AddScore(int points)
    {
        score += points;              
        UpdateScoreText();            
    }

    
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;  
    }
}

