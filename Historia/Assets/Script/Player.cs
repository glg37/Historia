using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public GameObject sword;
    public GameObject shield;
    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        // Pular
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Atacar 
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        // Defender
        if (Input.GetMouseButtonDown(1))
        {
            Defend(true);
        }

        if (Input.GetMouseButtonUp(1))
        {
            Defend(false);
        }
    }

    void Attack()
    {
       
        sword.GetComponent<Sword>().Swing(gameObject); 
    }

    void Defend(bool defend)
    {
        shield.SetActive(defend);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
