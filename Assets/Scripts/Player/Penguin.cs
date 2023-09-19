using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Penguin : Player
{   
    [SerializeField]
    private Transform bulletPos;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Movement();
        GroundCheck();
        Attack();
    }
    private void FixedUpdate()
    {
        //if (fixedJump)
        //{
        //    ani.SetBool("isJump", true);
        //    rigid.velocity = Vector2.up * jumpPower;
        //    fixedJump = false;
        //}
    }
    
    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            ani.SetBool("isAttack",true);
        }
    }
    void FinishAttack()
    {
        ani.SetBool("isAttack", false);
    }
    void LaunchMissile()
    {
        GameObject bulletobj = Instantiate(bullet, bulletPos.position,Quaternion.identity);
        if (transform.localScale.x==-1)
        {
            bulletobj.GetComponent<PenguinMissile>().Direction = -1;
            bullet.transform.eulerAngles = new Vector3(0, 180f, 0);
        }
        else
        {
            bulletobj.GetComponent<PenguinMissile>().Direction = 1;
            bullet.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
