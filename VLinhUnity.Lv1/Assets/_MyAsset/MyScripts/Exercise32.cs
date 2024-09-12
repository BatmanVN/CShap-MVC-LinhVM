using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exercise32 : MonoBehaviour
{
    [SerializeField] private string nameScene;

    public void ExitMap(Button btn)
    {
        SceneManager.LoadScene(nameScene);
        Debug.Log("Button Name: "+btn.name);
    }
}
