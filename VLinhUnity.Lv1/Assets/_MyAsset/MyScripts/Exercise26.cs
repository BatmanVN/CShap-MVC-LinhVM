using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exercise26 : MonoBehaviour
{
    public string nameScene;
    void Start()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(nameScene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
