using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise31 : MonoBehaviour
{
    private static Exercise31 instance = null;

    public static Exercise31 Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
