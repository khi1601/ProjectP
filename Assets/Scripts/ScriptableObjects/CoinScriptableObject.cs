using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(fileName ="CoinScriptableObject", menuName ="ScriptableObjects/Coin")]
public class CoinScriptableObject : ScriptableObject
{
    public int coin = 0;

    public static event Action OnCoinGet;

    public void IncreaseCoin(int amount)
    {
        coin += amount;
        OnCoinGet?.Invoke();
    }
}
