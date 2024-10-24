using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    [Header("Dialogo NPC")]
    public float interactionRange = 3f;
    public GameObject dialogueUI;
    public string npcDialogue = "Não é por aqui, capitão. Volte e mate os muçulmanos e domine os territórios deles no Egito.";

    [Header("Player")]
    private Transform player;
    private Player player2;

    [Header("Botao Interação")]
    public GameObject interactButton;
    public Button exitButton;

    private bool hasInteracted = false; 

    void Start()
    {
        player2 = FindObjectOfType<Player>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        dialogueUI.SetActive(false);
        interactButton.SetActive(false);
        exitButton.gameObject.SetActive(false);
        exitButton.onClick.AddListener(ExitNpc);
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= interactionRange && !hasInteracted)
        {
            if (!dialogueUI.activeSelf)
            {
                interactButton.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                AbrirDialogo();
            }
        }
        else
        {
            interactButton.SetActive(false);
        }
    }

    void AbrirDialogo()
    {
        dialogueUI.SetActive(true);
        dialogueUI.GetComponentInChildren<UnityEngine.UI.Text>().text = npcDialogue;
        exitButton.gameObject.SetActive(true);
        interactButton.SetActive(false);
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
        hasInteracted = true; 
        interactButton.SetActive(false); 
    }
}
