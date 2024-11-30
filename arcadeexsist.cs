using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcadeexsist : MonoBehaviour
{
    public GameObject task2_1;
    public GameObject Arcadedoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(task2_1 != null && task2_1.activeInHierarchy)
        {
            Arcadedoor.SetActive(true);
        }
        
    }
}
