using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Penguin : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpPower;
    public bool isground;
    private bool fixedJump;
    private Rigidbody2D rigid;
    private Animator ani;
    public LayerMask islayer;
    // Start is called before the first frame update
    void Start()
    {
        isground = true;
        fixedJump = false;
        rigid= GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Movement();
        GroundCheck();
    }
    private void FixedUpdate()
    {
        if (fixedJump)
        {
            ani.SetBool("isJump", true);
            rigid.velocity = Vector2.up * jumpPower;
            fixedJump = false;
        }
    }
    void Movement()
    {
        Vector3 flipMove=Vector3.zero;
        if(Input.GetAxisRaw("Horizontal")<0)
        {
            flipMove = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(Input.GetAxisRaw("Horizontal") >0)
        {
            flipMove = Vector3.right;
            transform.localScale=new Vector3(1, 1, 1);
        }
        else
            flipMove = Vector3.zero;
        transform.position += flipMove * moveSpeed * Time.deltaTime;

    }
    void Jump()
    {
        if((isground|| Physics2D.OverlapCircle(transform.position, 0.59f, islayer) )&& Input.GetKeyDown(KeyCode.Space) )
        {
            isground = false;
            fixedJump = true;
        }
    }
    void GroundCheck()
    {
        //isground = Physics2D.OverlapCircle(transform.position, 0.59f, islayer);
        Vector3 rayPos = new Vector3(transform.position.x, transform.position.y-0.45f, transform.position.z);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, new Vector3(0, -1, 0), 0.04f, LayerMask.GetMask("Ground"));

        if (hit.collider != null)
        {
            isground = true;
        }
        else
        {
            isground= false;
        }

        if (isground&&rigid.velocity.y<=0f)
        {
            rigid.velocity = new Vector3(rigid.velocity.x, 0, 0);
            ani.SetBool("isJump", false);
        }
    }
}
