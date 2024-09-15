using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool isCollect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            isCollect = true;
        }
    }
    public void DestroyCoin(float time)
    {
        if (isCollect == true)
            Destroy(gameObject,time);
    }
}
