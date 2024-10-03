using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public Slider healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

  
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Player tomou " + damage + " de dano.");

       
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
      
        Debug.Log("Player morreu.");
       
        Destroy(gameObject);
    }
}
