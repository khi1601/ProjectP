using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField]
    private Image[] images;

    public HealthScriptableObject healthManager;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        HPUpdate();
    }

    private void HPUpdate()
    {
        int currentHP = healthManager.health;

        if(0<currentHP && currentHP<=5)
        {
            images[0].fillAmount = 0.5f;
            images[1].fillAmount = 0;
            images[2].fillAmount = 0;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(5<currentHP && currentHP<=10)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 0f;
            images[2].fillAmount = 0;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(10<currentHP && currentHP<=15)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 0.5f;
            images[2].fillAmount = 0;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(15<currentHP && currentHP<=20)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 0f;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(20<currentHP && currentHP<=25)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 0.5f;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(25<currentHP && currentHP<=30)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 1.0f;
            images[3].fillAmount = 0;
            images[4].fillAmount = 0;
        }
        if(30<currentHP && currentHP<=35)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 1.0f;
            images[3].fillAmount = 0.5f;
            images[4].fillAmount = 0;
        }
        if(35<currentHP && currentHP<=40)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 1.0f;
            images[3].fillAmount = 1.0f;
            images[4].fillAmount = 0;
        }
        if(40<currentHP && currentHP<=45)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 1.0f;
            images[3].fillAmount = 1.0f;
            images[4].fillAmount = 0.5f;
        }
        if(45<currentHP && currentHP<=50)
        {
            images[0].fillAmount = 1.0f;
            images[1].fillAmount = 1.0f;
            images[2].fillAmount = 1.0f;
            images[3].fillAmount = 1.0f;
            images[4].fillAmount = 1.0f;
        }
    }
}
