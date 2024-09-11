using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise12 : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter in the door");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit in the door");
    }
    void Update()
    {
        
    }
}
