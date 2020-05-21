using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play2Kick : MonoBehaviour
{
    private bool isKicking = false;
    float damage = 5f;

    private float attackTimer = 0;
    private float attackCd = .5f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Player 2 collided with " + col.name);
        col.gameObject.GetComponent<HealthBar> ().TakeDamage(damage);
    }

    void Update()
    {
        if (Input.GetKeyDown("m") && !isKicking)
        {
            isKicking = true;
            attackTimer = attackCd;

            attackTrigger.enabled = true;

        }
        //if ((attackTrigger2.enabled) == true && Physics2D.IsTouching(attackTrigger2, getPlayerKick()))
      
        if (isKicking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                isKicking = false;
                attackTrigger.enabled = false;
            }
        }
        anim.SetBool("IsKicking", isKicking);
    }

}
