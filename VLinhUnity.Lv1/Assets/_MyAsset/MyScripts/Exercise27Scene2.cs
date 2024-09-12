using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise27Scene2 : MonoBehaviour
{
    public string keyString;
    public string keyInt;
    public string keyFloat;
    private string valueString;
    private int valueInt;
    private float valueFloat;
    void Start()
    {
        valueString = PlayerPrefs.GetString(keyString, valueString);
        valueInt = PlayerPrefs.GetInt(keyInt, valueInt);
        valueFloat = PlayerPrefs.GetFloat(keyFloat, valueFloat);
        Debug.Log("String: " + valueString);
        Debug.Log("Int: " + valueInt);
        Debug.Log("Float: " + valueFloat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
