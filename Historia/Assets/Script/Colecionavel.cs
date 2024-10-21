using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecionavel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            ColecionavelUI colecionavelUI = FindObjectOfType<ColecionavelUI>(); 

            if (player != null && colecionavelUI != null)
            {
               
                colecionavelUI.ColetavelPegado();
                Destroy(gameObject);
            }
        }
    }
}
