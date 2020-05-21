using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{

    public Player1Controller controller;
    public Animator animator;

    public float runSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * runSpeed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -runSpeed * Time.deltaTime;
        }
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(transform.hasChanged && controller.isGrounded)
        {
            animator.SetBool("IsWalking", true);
            transform.hasChanged = false;
        } else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move();
    }

}
