using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise34 : MonoBehaviour
{
    private const string nameURL = "https://assetstore.unity.com/";
    public void GetAsset()
    {
        Application.OpenURL(nameURL);
    }
}
