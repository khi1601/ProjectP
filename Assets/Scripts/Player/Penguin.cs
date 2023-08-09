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
    private Rigidbody2D rigidbody;
    private Animator ani;
    public LayerMask islayer;
    // Start is called before the first frame update
    void Start()
    {
        isground = true;
        rigidbody= GetComponent<Rigidbody2D>();
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
        if(isground&&Input.GetKeyDown(KeyCode.A))
        {
            isground = false;
            ani.SetBool("isJump", true);
            rigidbody.velocity = Vector2.up * jumpPower;
           
        }
    }
    void GroundCheck()
    {
        isground = Physics2D.OverlapCircle(transform.position, 0.49f, islayer);
        if(isground&&rigidbody.velocity.y<=0f)
            ani.SetBool("isJump", false);
    }
}
