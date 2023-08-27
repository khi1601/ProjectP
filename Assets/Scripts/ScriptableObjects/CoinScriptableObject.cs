using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="CoinScriptableObject", menuName ="ScriptableObjects/Coin")]
public class CoinScriptableObject : ScriptableObject
{
    public int coin = 0;

    [System.NonSerialized]
    public UnityEvent<int> coinChangeEvent;

    private void OnEnable()
    {
        if (coinChangeEvent == null)
            coinChangeEvent = new UnityEvent<int>();
    }

    public void DecreaseCoin(int amount)
    {
        coin -= amount;
        coinChangeEvent.Invoke(coin);
    }

    public void IncreaseCoin(int amount)
    {
        coin += amount;
        coinChangeEvent.Invoke(coin);
    }
}
