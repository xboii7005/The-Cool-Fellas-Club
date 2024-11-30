using UnityEngine;
using TMPro; 

public class BulletBehavior : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private static int score = 0; 
    public GameObject red;   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid")) 
        {
            
            Destroy(other.gameObject); 
            Destroy(gameObject);

            
            score += 5;

            
            scoreText.text = "Score: " + score;
        }
        
    }
    void Update()
    {
        if(red.activeInHierarchy && score >= 10)
        {
            score -= 10;

            
            scoreText.text = "Score: " + score;
            red.SetActive(false);
        }
    }
}


