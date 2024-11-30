using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform player;       
    public float smoothSpeed = 0.125f;  
    public Vector3 offset;         
    
    public float minX = -10f;      
    public float maxX = 10f;      

    private void LateUpdate()
    {
        if (player == null) return;

        
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, transform.position.y, transform.position.z);

        
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX);

        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
