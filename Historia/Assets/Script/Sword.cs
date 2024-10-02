using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword: MonoBehaviour
{
    public float attackDamage = 10f;
    public float attackRange = 1f;
    public LayerMask enemyLayer;

    public void Swing(GameObject attacker)
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
    }

    void OnDrawGizmosSelected()
    {
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}