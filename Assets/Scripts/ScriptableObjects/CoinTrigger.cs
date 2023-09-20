using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{

    [SerializeField, Tooltip("the coin's value")]
    private int coins = 1;

    [SerializeField]
    private CoinScriptableObject coinManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinManager.IncreaseCoin(coins);
            gameObject.SetActive(false);
        }
    }
}
