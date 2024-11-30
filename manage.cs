using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manage : MonoBehaviour
{
    public GameObject task2_1;
    public GameObject task2_2;
    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(task2_1.activeInHierarchy == false)
        {
            task2_2.SetActive(true);
            exit.SetActive(true);
        }
    }
}
