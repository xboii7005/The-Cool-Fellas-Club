using UnityEngine;

public class astrmove : MonoBehaviour
{
    public float speed = 5f; // Speed at which the object moves to the left

    void Update()
    {
        // Move the object to the left every frame
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    
}

