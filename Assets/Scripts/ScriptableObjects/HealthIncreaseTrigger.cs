using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncreaseTrigger : MonoBehaviour
{
    [SerializeField, Tooltip("How much should the player's health Increase")]
    private float helathIncreaseAmount = 10;

    [SerializeField]
    private HealthScriptableObject healthManager;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            healthManager.IncreaseHealth(helathIncreaseAmount);
            gameObject.SetActive(false);
        }
    }
}
