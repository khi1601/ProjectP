using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncreaseTrigger : MonoBehaviour
{
    [SerializeField, Tooltip("How much should the player's health Increase")]
    private int helathIncreaseAmount = 10;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {

        }
    }
}
