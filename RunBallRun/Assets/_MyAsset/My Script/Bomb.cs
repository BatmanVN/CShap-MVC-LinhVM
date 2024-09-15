using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject vfExplosion;
    private bool isBoom;

    public bool IsBoom { get => isBoom; set => isBoom = value; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            IsBoom = true;
        }
    }
    public void EnableVFX(float time)
    {
        if (IsBoom)
        {
            vfExplosion.SetActive(true);
            Destroy(gameObject, time);
        }
    }
}
