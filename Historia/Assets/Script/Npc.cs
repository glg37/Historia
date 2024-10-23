using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    [Header("Dialgo Npc")]
    public float interactionRange = 3f;
    public GameObject dialogueUI;
    public string npcDialogue = "N�o � por aqui, capit�o. Volte e mate os mu�ulmanos e domine os territ�rios deles no Egito.";


    private Transform player;
    public Button exitButton;
    private Player player2;
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
