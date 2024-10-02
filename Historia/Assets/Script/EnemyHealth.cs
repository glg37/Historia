using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 50f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Inimigo tomou " + damage + " de dano.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
       
        Debug.Log(" morreu.");
        Destroy(gameObject);
    }
}