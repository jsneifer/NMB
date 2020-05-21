using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play2Kick : MonoBehaviour
{
    private bool isKicking = false;

    private float attackTimer = 0;
    private float attackCd = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (attackTrigger.enabled == true)
        {
            Debug.Log("hit");
        }
        if (attackTrigger.enabled == false)
        {
            Debug.Log("not hit");
        }
            
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
