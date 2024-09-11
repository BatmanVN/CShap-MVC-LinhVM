using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Decteted, Collision name is: " + collision.gameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
