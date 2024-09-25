using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject punchHitbox; 


    void Update()
    {
        if (Input.GetButtonDown("Fire1_P1"))
        {
            Attack();
        }
        else if (Input.GetButtonDown("Fire1_P2"))
        {
            Attack();

        }
    }

    void Attack()
    {
        
        punchHitbox.SetActive(true);
        Invoke("DisableHitbox", 0.2f); 
    }

    void DisableHitbox()
    {
        punchHitbox.SetActive(false);
    }
}
