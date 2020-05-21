using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    public Player2Controller controller;
    public Animator animator;

    public float runSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * runSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * -runSpeed * Time.deltaTime;
        }

        if (transform.hasChanged)
        {
            animator.SetBool("IsWalking", true);
            transform.hasChanged = false;
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move();
    }
}