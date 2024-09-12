using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excersice21 : MonoBehaviour
{
    Animator playerAnimation;
    Rigidbody playerRig;
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
        playerRig = GetComponent<Rigidbody>();
    }

    void PlayMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRig.AddForce(new Vector3(0, 0, 0.2f), ForceMode.VelocityChange);
            playerRig.rotation = Quaternion.LookRotation(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRig.AddForce(new Vector3(0, 0, -0.2f), ForceMode.VelocityChange);
            playerRig.rotation = Quaternion.LookRotation(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRig.AddForce(new Vector3(-0.2f, 0, 0), ForceMode.VelocityChange);
            playerRig.rotation = Quaternion.LookRotation(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRig.AddForce(new Vector3(0.2f, 0, 0), ForceMode.VelocityChange);
            playerRig.rotation = Quaternion.LookRotation(Vector3.right);
        }
        StatusAnim();
    }
    void StatusAnim()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A)
            || Input.GetKeyDown(KeyCode.D))
        {
            AnimMove();
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A)
            || Input.GetKeyUp(KeyCode.D))
        {
            playerRig.velocity = Vector3.zero;
            AnimStop();
        }
    }
    void AnimMove() => playerAnimation.SetBool("Walk",true);
    void AnimStop() => playerAnimation.SetBool("Walk", false);

    void Update()
    {
        PlayMove();
    }
    private void FixedUpdate()
    {
        PlayMove();
    }
}
