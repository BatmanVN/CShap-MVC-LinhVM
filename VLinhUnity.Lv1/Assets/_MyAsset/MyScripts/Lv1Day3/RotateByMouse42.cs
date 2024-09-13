using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse42: MonoBehaviour
{
    //private float yaw = 0.0f;
    //private float pitch = 0.0f;
    //public float speedH;
    //public float speedV;
    [SerializeField] private float angleLockDistance;
    [SerializeField] private Transform cameraHold;
    [SerializeField] private float minPitch;
    [SerializeField] private float maxPitch;

    private float pitch;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void UpdateaYaw()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float deltaYaw = mouseX * angleLockDistance;
        transform.Rotate(0, deltaYaw, 0 );
    }

    private void UpdatePitch()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float dealtaY = mouseY * angleLockDistance;
        pitch = Mathf.Clamp(pitch + dealtaY,minPitch,maxPitch);
        cameraHold.localEulerAngles = new Vector3(pitch,0,0);
    }
    void Update()
    {
        UpdateaYaw();
        UpdatePitch();
        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");
        //transform.eulerAngles = new Vector3(yaw, pitch, 0.0f);
    }


}
