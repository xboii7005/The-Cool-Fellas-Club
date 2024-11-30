using System.Collections;
using UnityEngine;

public class doit : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public Vector2 spawnPosition;   
    public float spawnInterval = 2f; 

    private Coroutine spawnCoroutine; 

    void Start()
    {
       
        StartSpawning();
    }

    public void StartSpawning()
    {
        if (spawnCoroutine == null)
        {
            spawnCoroutine = StartCoroutine(SpawnObjects());
        }
    }

    public void StopSpawning()
    {
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
            spawnCoroutine = null;
        }
    }

    private IEnumerator SpawnObjects()
    {
        while (true) 
        {
            if (objectToSpawn != null)
            {
                Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            }
            else
            {
                Debug.LogError("No object assigned to spawn!");
            }

            
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

