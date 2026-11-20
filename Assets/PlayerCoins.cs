using System;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int coin;
    public event Action Collect;
    public event Action<int> OnAddCoin;
    public event Action<int> OnCoinInnit;
    void Start()
    {
        coin = 0;
        OnCoinInnit.Invoke(coin);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddCoin(int CoinToAdd)
    {
        coin += CoinToAdd;
    }
}
