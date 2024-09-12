using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise27Scene1 : MonoBehaviour
{
    public string keyString;
    public string keyInt;
    public string keyFloat;
    void Start()
    {
        PlayerPrefs.SetString(keyString, "!!!This is a Sring!!!");
        PlayerPrefs.SetInt(keyInt,123);
        PlayerPrefs.SetFloat(keyFloat, 3.21f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
