using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public GameObject sword;
    private Rigidbody2D rb;
    private Transform player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
       
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);
        }

       
        if (Vector2.Distance(transform.position, player.position) < 2f)
        {
            Attack();
        }
    }

    void Attack()
    {
       
        sword.GetComponent<Sword>().Swing(gameObject); 
    }
}