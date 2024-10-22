using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public float interactionRange = 3f;
    public GameObject dialogueUI; 
    public string npcDialogue = "Nao e aqui capitao,volte e tomine o territorio ";

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dialogueUI.SetActive(false); 
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= interactionRange)
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                AbrirDialogo();
            }
        }
        else
        {
            dialogueUI.SetActive(false);
        }
    }

    void AbrirDialogo()
    {
        dialogueUI.SetActive(true);
        dialogueUI.GetComponentInChildren<UnityEngine.UI.Text>().text = npcDialogue; 
    }
}
