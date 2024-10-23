using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    [Header("Dialgo Npc")]
    public float interactionRange = 3f;
    public GameObject dialogueUI;
    public string npcDialogue = "Não é por aqui, capitão. Volte e mate os muçulmanos e domine os territórios deles no Egito.";

    [Header("PLayer")]
    private Transform player;
    private Player player2;

    [Header("Botao Sair")]
    public Button exitButton;
    void Start()
    {
        player2 = FindObjectOfType<Player>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dialogueUI.SetActive(false);
        exitButton.onClick.AddListener(ExitNpc);
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
            exitButton.gameObject.SetActive(false);
        }
    }

    void AbrirDialogo()
    {
        dialogueUI.SetActive(true);
        
        dialogueUI.GetComponentInChildren<UnityEngine.UI.Text>().text = npcDialogue;
        exitButton.gameObject.SetActive(true);
        player2.SetCanMove(false);
    }
    public void ExitNpc()
    {
       EndDialogo();
    }
    public void EndDialogo()
    {
        player2.SetCanMove(true);
        dialogueUI.SetActive(false);
       
        exitButton.gameObject.SetActive(false);
        
    }
}
