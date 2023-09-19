using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyBox;
public class PenguinMissile : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float life;
    [SerializeField]
    private float damage;
    private float Acctime;
    private int direction;
    public int Direction { get => direction; set => direction = value; }
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        Acctime = 0.0f;
        sr=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Acctime += Time.deltaTime;
        if (Acctime >= life)
            Destroy(gameObject);
        
    }
    private void Movement()
    {
        transform.Translate(speed * Time.deltaTime * direction, 0, 0, Space.World);
    }
}
