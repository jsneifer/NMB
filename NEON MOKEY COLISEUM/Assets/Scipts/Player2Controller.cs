using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    public Animator animator;
    public float jumpforce;

    public float P2screenPosition;
    public float P1screenPosition;

    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    Rigidbody2D rb;
    Animator anim;
    public bool jump = false;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar2 healthBar2;

    private GameObject completeLevelUI;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar2.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.N)) anim.SetTrigger("Hit");
        //if (Input.GetKeyDown(KeyCode.M)) anim.SetTrigger("Hit");

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.velocity = (Vector2.up * jumpforce);
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }

        P2screenPosition = transform.position.x;
        P1screenPosition = GameObject.Find("Player1").GetComponent<Player1Controller>().P1screenPosition;

    }

    public void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

    }
    public void Move()
    {
        // rb.velocity = new Vector2(speed * 10f, rb.velocity.y);

        // If the input is moving the player right and the player is facing left...
        if (P1screenPosition > P2screenPosition && !facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (P2screenPosition > P1screenPosition && facingRight)
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
