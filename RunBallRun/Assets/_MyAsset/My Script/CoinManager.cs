using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private List<Coin> coins = new List<Coin>();
    [SerializeField] private float time;

    private void CollectCoin()
    {
        foreach (Coin coin in coins)
        {
            if (coin != null)
                coin.DestroyCoin(time);
        }
    }
    private void Update()
    {
        CollectCoin();
    }
}
