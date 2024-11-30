using UnityEngine;

public class labshoot : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint;     
    public float bulletSpeed = 10f; 
       
    

    void Start()
    {
        
        
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

       
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = firePoint.right * bulletSpeed;
        }

      
        
    }
}

