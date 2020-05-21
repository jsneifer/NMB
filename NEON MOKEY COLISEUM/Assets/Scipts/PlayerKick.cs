﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKick : MonoBehaviour
{
    private bool isKicking = false;

    private float attackTimer = 0;
    private float attackCd = .5f;

    float damage = 5f;

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
        if (Input.GetKeyDown("q") && !isKicking)
        {
            isKicking = true;
            attackTimer = attackCd;

            attackTrigger.enabled = true;

        }
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

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Player 2 collided with " + col.name);
        col.gameObject.GetComponent<HealthBar2>().TakeDamage(damage);
    }

}
