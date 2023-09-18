using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBar : MonoBehaviour
{
    public GameObject heartPrefab;

    [SerializeField]
    HealthScriptableObject healthManager;

    List<HealthHeart> hearts = new List<HealthHeart>();

    private void OnEnable()
    {
        HealthScriptableObject.OnPlayerHealed += DrawHearts;
    }
    private void OnDisable()
    {
        HealthScriptableObject.OnPlayerHealed -= DrawHearts;
    }
    private void Start()
    {
        DrawHearts();
    }
    public void DrawHearts()
    {
        ClearHearts();

        float maxHelathRemainder = healthManager.maxHealth % 2;
        int heartsToMake = (int)(healthManager.maxHealth / 2 + maxHelathRemainder);
        for (int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        for (int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = Mathf.Clamp(healthManager.health - (i * 2), 0, 2);
            hearts[i].SetHeartImg((HeartStatus)heartStatusRemainder);
        }
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImg(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealthHeart>();
    }
}
