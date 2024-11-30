using System.Collections;
using UnityEngine;

public class sadfellacry : MonoBehaviour
{
    
    public float activeDuration = 5f;

    private Coroutine activationCoroutine;

    private void Start()
    {
        
        gameObject.SetActive(false);
    }

    
    public void ActivateForLimitedTime()
    {
        
        if (activationCoroutine != null)
        {
            StopCoroutine(activationCoroutine);
        }

        
        gameObject.SetActive(true);
        activationCoroutine = StartCoroutine(DeactivateAfterTime());
    }

    private IEnumerator DeactivateAfterTime()
    {
        yield return new WaitForSeconds(activeDuration);
        gameObject.SetActive(false);
    }
}
