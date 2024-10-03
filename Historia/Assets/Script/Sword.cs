using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword: MonoBehaviour
{
    public float attackDamage = 10f;
    public float attackRange = 1f;
    public LayerMask enemyLayer;
    public float attackCooldown = 2f; 
    private bool canAttack = true;

    public void Swing(GameObject attacker)
    {
        if (canAttack)
        {
            
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);

            foreach (Collider2D enemy in hitEnemies)
            {
                if (enemy.gameObject != attacker)
                {
                    if (enemy.CompareTag("Player"))
                    {
                        enemy.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
                    }
                    else if (enemy.CompareTag("Enemy"))
                    {
                        enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
                    }
                }
            }

          
            StartCoroutine(AttackCooldown());
        }
    }

    private IEnumerator AttackCooldown()
    {
        canAttack = false; 
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true; 
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}