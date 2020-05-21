using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Punch : MonoBehaviour
{
    private bool isPunching = false;

    float damage = 10f;

    private float attackTimer = 0;
    private float attackCd = 1f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n") && !isPunching)
        {
            isPunching = true;
            attackTimer = attackCd;
            attackTrigger.enabled = true;

        }
        if (isPunching)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                isPunching = false;
                attackTrigger.enabled = false;
            }
        }
        anim.SetBool("IsPunching", isPunching);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Player 2 collided with " + col.name);
        col.gameObject.GetComponent<HealthBar>().TakeDamage(damage);
    }
}
