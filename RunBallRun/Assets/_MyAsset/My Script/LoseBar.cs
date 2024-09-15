using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseBar : MonoBehaviour
{
    [SerializeField] private string nameScene;
    public void PlayAgain()
    {
        SceneManager.LoadScene(nameScene);
        Time.timeScale = 1f;
    }
}
