using UnityEngine;

public class labmove : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint;     
    public float bulletSpeed = 10f; 
    
    private bool isFacingRight = true; 

    void Start()
    {
        
       
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        
        HandleFlip();
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

    void HandleFlip()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        
        isFacingRight = !isFacingRight;

        
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

        
        Vector3 firePointScale = firePoint.localScale;
        firePointScale.x *= -1;
        firePoint.localScale = firePointScale;

        
        firePoint.localRotation = Quaternion.Euler(0, isFacingRight ? 0 : 180, 0);
    }
}

