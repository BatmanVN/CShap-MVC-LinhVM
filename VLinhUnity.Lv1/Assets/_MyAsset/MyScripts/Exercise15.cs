using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(cubeAnimation), 2.0f);
    }

    void cubeAnimation()
    {
        GameObject.Find("Cube1").GetComponent<Animator>().SetBool("isMoving", true);

        Invoke(nameof(humanAnimation), 2.0f);
    }

    void humanAnimation()
    {
        GameObject.Find("Human1").GetComponent<Animator>().SetBool("isHumanMoving", true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
