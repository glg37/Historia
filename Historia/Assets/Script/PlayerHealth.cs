using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public Image healthBar; 
    public Vector3 healthBarOffset = new Vector3(0, 2, 0);
    public Camera mainCamera;

    public GameObject espada;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.fillAmount = currentHealth / maxHealth;

        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {

       
        Vector3 worldPosition = transform.position + healthBarOffset;
        Vector3 screenPosition = mainCamera.WorldToScreenPoint(worldPosition);
        //healthBar.transform.position = screenPosition;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Player tomou " + damage + " de dano.");

        
        healthBar.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
        espada.SetActive(false);

    }
}