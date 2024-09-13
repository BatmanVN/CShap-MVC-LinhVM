using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByMouse43 : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                0.0f,Input.GetAxisRaw("Mouse Y") * Time.deltaTime *speed);
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }
    }
}
