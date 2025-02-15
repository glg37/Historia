using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    [Header("Mec�nicas Enemy")]
    public float speed = 3f;
    public GameObject sword;
    public LayerMask playerLayer;
    public float visionRange = 5f;
    public float attackRange = 2f;

    private Transform player;
    private Rigidbody2D rb;
    private bool canMove = true;
    private bool isPatrolling = true;
    private bool isFacingRight = false;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            if (IsPlayerInSight())
            {
                canMove = true;
                isPatrolling = false;
                MoveTowardsPlayer();
            }
            else
            {
                isPatrolling = true;
                Patrol();
            }

            if (Vector2.Distance(transform.position, player.position) < attackRange && canMove)
            {
                Attack();
            }
            else
            {
                animator.SetBool("Ataque", false);
            }
        }
    }

    bool IsPlayerInSight()
    {
       
        Vector2 direction = isFacingRight ? Vector2.right : Vector2.left;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange, playerLayer);
        return hit.collider != null && hit.collider.CompareTag("Player");
    }

    void MoveTowardsPlayer()
    {
        if (canMove)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);

           
            if ((direction.x > 0 && !isFacingRight) || (direction.x < 0 && isFacingRight))
            {
                Flip();
            }
        }
    }

    void Patrol()
    {
        if (isPatrolling)
        {
           
            rb.velocity = new Vector2((isFacingRight ? speed : -speed), rb.velocity.y);
        }
    }

    void Attack()
    {
        
        animator.SetBool("Ataque", true);

       
        sword.GetComponent<Sword>().Swing(gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    public void SetCanMove(bool value)
    {
        canMove = value;
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Vector2 direction = isFacingRight ? Vector2.right : Vector2.left;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + direction * visionRange);
    }
}