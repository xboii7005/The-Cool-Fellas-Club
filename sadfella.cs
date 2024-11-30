using UnityEngine;

public class sadfella : MonoBehaviour
{
    
    public sadfellacry targetItem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player") && targetItem != null)
        {
            
            targetItem.ActivateForLimitedTime();
        }
    }
}

