using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwancoin : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public float spawnY = 0f;        
    public float minX = -5f;         
    public float maxX = 5f;         
    public float spawnInterval = 2f; 

    private float timer;

    private void Update()
    {
        // Countdown timer
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnObject();
            timer = spawnInterval; 
        }
    }

    private void SpawnObject()
    {
       
        float randomX = Random.Range(minX, maxX);

        
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
