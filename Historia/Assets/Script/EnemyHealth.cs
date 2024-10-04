using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public Slider healthBar;
    public Vector3 healthBarOffset = new Vector3(0, 2, 0);
    public Camera mainCamera;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {

        Vector3 worldPosition = transform.position + healthBarOffset;
        Vector3 screenPosition = mainCamera.WorldToScreenPoint(worldPosition);

        healthBar.transform.position = screenPosition;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Inimigo tomou " + damage + " de dano.");

        healthBar.value = currentHealth;

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