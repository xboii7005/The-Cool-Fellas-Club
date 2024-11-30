using UnityEngine;

public class RandomSpawner2D : MonoBehaviour
{
    public GameObject item1;  
    public GameObject item2;   

    public float spawnX = 0f;  
    public float minY = -5f;   
    public float maxY = 5f;    

    public float spawnInterval = 2f;  
    private float timer;              

    private void Update()
    {
        
        timer += Time.deltaTime;

        
        if (timer >= spawnInterval)
        {
            SpawnItem();
            timer = 0f;  
        }
    }

    private void SpawnItem()
    {
        
        GameObject selectedItem = Random.value > 0.5f ? item1 : item2;

        
        if (selectedItem != null)
        {
            
            float randomY = Random.Range(minY, maxY);

           
            Instantiate(selectedItem, new Vector3(spawnX, randomY, 0f), Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("One or both of the spawn items are not assigned!");
        }
    }
}
