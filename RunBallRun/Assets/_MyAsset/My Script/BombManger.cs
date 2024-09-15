using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManger : MonoBehaviour
{
    [SerializeField] private List<Bomb> bombs = new List<Bomb>();
    [SerializeField] private GameObject loseBar;
    [SerializeField] private float time;

    private void Explosion()
    {
        foreach (Bomb bomb in bombs)
        {
            if(bomb != null)
            {
                bomb.EnableVFX(time);
                if (bomb.IsBoom)
                {
                    Invoke(nameof(EnableLoseBar), 0.4f);
                }
            }
        }
    }
    private void EnableLoseBar()
    {
        loseBar.SetActive(true);
        Time.timeScale = 0;
    }
    private void Update()
    {
        Explosion();
    }
}
