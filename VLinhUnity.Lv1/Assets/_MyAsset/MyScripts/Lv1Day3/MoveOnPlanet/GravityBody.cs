using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public Planet attractorPlanet;
    private Transform playerTranform;

    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTranform = transform;
    }
    void FixedUpdate()
    {
        if(attractorPlanet)
        {
            attractorPlanet.Attract(playerTranform);
        }    
    }
}
