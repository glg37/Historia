using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour

   {
    public float blockReduction = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyAttack"))
        {
           
            PlayerHealth playerHealth = GetComponentInParent<PlayerHealth>();
            playerHealth.TakeDamage(collision.GetComponent<Sword>().attackDamage * blockReduction);
        }
    }
}

