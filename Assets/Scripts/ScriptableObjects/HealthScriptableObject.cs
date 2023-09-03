using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="HealthScriptableObject", menuName ="ScriptableObjects/Health")]
public class HealthScriptableObject : ScriptableObject
{
    public int health = 0;

    [SerializeField]
    public int maxHealth = 50;

  //  [System.NonSerialized]
  //  public UnityEvent<int> healthChangeEvent;


    private void OnEnable()
    {
       // health = maxHealth;
       // if (healthChangeEvent == null)
        //    healthChangeEvent = new UnityEvent<int>();
    }

    public void DecreaseHealth(int amount)
    {
        health -= amount;
       // healthChangeEvent.Invoke(health);

    }
    public void IncreaseHealth(int amount)
    {
        health += amount;
        //healthChangeEvent.Invoke(health);
        if (health > maxHealth) //최대 체력을 넘기면
        {
            health = maxHealth;
        }
    }

}
