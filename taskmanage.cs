using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskmanage : MonoBehaviour
{
    public GameObject task1check;
    public GameObject task1txt;
    
    public GameObject task2txt;
    public GameObject task2check;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(task2txt != null &&task1check.activeInHierarchy == false)
        {
            task1txt.SetActive(false);
            task2txt.SetActive(true);
            task2check.SetActive(true);
        }
    }
}
