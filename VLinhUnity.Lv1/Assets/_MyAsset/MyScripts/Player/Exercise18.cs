using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise18 : MonoBehaviour
{
    GameObject playerObject;
    Vector3 cameraOffSet;
    void Start()
    {
        playerObject = GameObject.Find("Player");
        cameraOffSet = new Vector3(0.5f, 6, -10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position + cameraOffSet;
    }
}
