using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Player
{
    
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
        if (Input.GetKeyDown(KeyCode.D))
        {
            ani.SetBool("isAttack", true);
        }
    }
    void FinishAttack()
    {
        ani.SetBool("isAttack", false);
    }
}
