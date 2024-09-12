using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise23 : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("*ENABLE*");
        Invoke("OffMethod", 1);
        Invoke("OffMethod", 1);
    }

    private void OnDisable()
    {
        Debug.Log("*DISABLE*");
        Invoke("OnMethod", 1);
    }
    void OnMethod()
    {
        gameObject.SetActive(true);
    }
    void OffMethod()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
}
