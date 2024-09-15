using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private CharacterController ballController;
    private void Move()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        if (vInput < 0) return;
        Vector3 moveDirection = transform.right * hInput + transform.forward * vInput;
        ballController.SimpleMove(moveDirection*speed);
    }
    private void Update()
    {
        Move();
    }
}
