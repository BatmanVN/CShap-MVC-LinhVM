using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise19 : MonoBehaviour
{
    Rigidbody playerRigbody;
    void Start()
    {
        playerRigbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRigbody.AddForce(new Vector3(0, 0, 0.5f),ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigbody.AddForce(new Vector3(0, 0, -0.5f), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigbody.AddForce(new Vector3(-0.5f, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigbody.AddForce(new Vector3(0.5f, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigbody.AddForce(new Vector3(0, 6, 0), ForceMode.VelocityChange);
        }
    }
}
