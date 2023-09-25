using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinUITxt;

    [SerializeField]
    private CoinScriptableObject coinManager;


    private void OnEnable()
    {
       // coinUITxt = GetComponent<TextMeshProUGUI>();

        CoinScriptableObject.OnCoinGet += UpdateCoin;
    }
    private void OnDisable()
    {
        CoinScriptableObject.OnCoinGet -= UpdateCoin;
    }
    public void UpdateCoin()
    {
        coinUITxt.text = (coinManager.coin).ToString();
    }
}
