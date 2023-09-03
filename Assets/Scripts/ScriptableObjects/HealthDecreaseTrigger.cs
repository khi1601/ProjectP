using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecreaseTrigger : MonoBehaviour
{
    [SerializeField, Tooltip("How much should the player's health Decrease")]
    private int helathDecreaseAmount = 10;

    [SerializeField]
    private HealthScriptableObject healthManager;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            healthManager.DecreaseHealth(helathDecreaseAmount);

            gameObject.SetActive(false);
        }
    }
}
