using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]private Material backGround;

    private void Start()
    {
        UpdateSky();
    }
    private void UpdateSky()
    {
        RenderSettings.skybox = backGround;    
    }
}
