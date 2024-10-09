using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    public GameObject EspadaEnemy;

    void Start()
    {
        
        currentHealth = maxHealth;
    }

    void Update()
    {
        
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
       
        if (EspadaEnemy != null)
        {
            EspadaEnemy.SetActive(false);
        }

        
        Destroy(gameObject);
    }
}