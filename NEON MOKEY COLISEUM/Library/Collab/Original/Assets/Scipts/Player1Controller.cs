using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{

    public Animator animator;
    public float jumpforce;

    private float move;

    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    Rigidbody2D rb;
    Animator anim;
    public bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) anim.SetTrigger("Hit");
        if (Input.GetKeyDown(KeyCode.F)) anim.SetTrigger("Hit");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = (Vector2.up * jumpforce);
            animator.SetBool("IsJumping", true);
        } else
        {
            animator.SetBool("IsJumping", false);
        }

    }

    public void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        
    }
    public void Move(float speed)
    {
        rb.velocity = new Vector2(speed*10f, rb.velocity.y);

        // If the input is moving the player right and the player is facing left...
        if (speed > 0 && !facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (speed < 0 && facingRight)
        {
            // ... flip the player.
            Flip();
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
