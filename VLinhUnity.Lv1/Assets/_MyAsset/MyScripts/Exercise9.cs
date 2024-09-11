using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource>().Play();
        AudioSource[] audioSourcesObj = GameObject.Find("AudioFiles").GetComponents<AudioSource>();
        audioSourcesObj[0].Play();
        audioSourcesObj[1].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
