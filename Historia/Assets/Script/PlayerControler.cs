using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    public string playerTag; // "Player1" ou "Player2"

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = 0;

        if (playerTag == "Player1")
        {
            moveInput = Input.GetAxisRaw("Horizontal_P1");
            if (Input.GetButtonDown("Jump_P1") && isGrounded)
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
        else if (playerTag == "Player2")
        {
            moveInput = Input.GetAxisRaw("Horizontal_P2");
            if (Input.GetButtonDown("Jump_P2") && isGrounded)
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}