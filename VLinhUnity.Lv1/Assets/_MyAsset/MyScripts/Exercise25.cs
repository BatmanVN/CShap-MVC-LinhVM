using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise25 : MonoBehaviour
{
    public List<Material> sky;
    private int random;
    //public Material starSky;
    //public Material animeSky;
    //public Material otherSky;
    void Start()
    {
        InvokeRepeating("UpdateSky", 2,2);
    }

    void UpdateSky()
    {
        random = Random.Range(0, sky.Count);
        RenderSettings.skybox = sky[random];
    }
    // Update is called once per frame
    void Update()
    {

    }
}
