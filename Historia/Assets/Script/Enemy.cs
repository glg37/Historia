using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    [Header("Mecanicas Enemy")]

    public float speed = 3f;
    public GameObject sword;
    private Transform player;


    private Rigidbody2D rb;
    
    private bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (canMove && player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (Vector2.Distance(transform.position, player.position) < 2f && canMove)
        {
            Attack();
        }
    }

    public void SetCanMove(bool value)
    {
        canMove = value;
    }

    void Attack()
    {
        sword.GetComponent<Sword>().Swing(gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Parede"))
        {
            transform.Rotate(0, 180, 0); 
            
            

        }
    }
}