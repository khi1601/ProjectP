using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="HealthScriptableObject", menuName ="ScriptableObjects/Health")]
public class HealthScriptableObject : ScriptableObject
{
    public int health = 0;
    public int numOfHearts;

    [SerializeField]
    public int maxHealth = 50;

    public static event Action OnPlayerHealed;

    public void DecreaseHealth(int amount)
    {
        health -= amount;
       // healthChangeEvent.Invoke(health);

    }
    public void IncreaseHealth(int amount)
    {
        health += amount;
        OnPlayerHealed?.Invoke();

        if (health > maxHealth) //최대 체력을 넘기면
        {
            health = maxHealth;
        }
    }

}
