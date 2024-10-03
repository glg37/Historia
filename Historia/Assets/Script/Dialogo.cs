using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public GameObject dialoguePanel; 
    public Text dialogueText;
    public GameObject dialogo;
    public Button exitButton; 
    private bool isDialogueActive = false;
    private Player player;
    private Enemy enemy;

    void Start()
    {
        player = FindObjectOfType<Player>();
        enemy = FindObjectOfType<Enemy>();
        exitButton.onClick.AddListener(ExitDialogue); 
        StartDialogue();
    }

    void StartDialogue()
    {
        isDialogueActive = true;
        dialoguePanel.SetActive(true);
        dialogo.SetActive(true);
        player.SetCanMove(false); 
        enemy.SetCanMove(false); 
        dialogueText.text = "Vamos lá, soldados! O Luís nos chamou de novo pra alcançarmos o Egito. Então, vamos matar esses muçulmanos e dominar alguns territórios do Egito!";
        exitButton.gameObject.SetActive(true);
        Invoke("EndDialogue", 100f); 
    }


    void ExitDialogue()
    {
        EndDialogue(); 
    }

    void EndDialogue()
    {
        dialogo.SetActive(false);
        isDialogueActive = false;
        dialoguePanel.SetActive(false); 
        player.SetCanMove(true); 
        enemy.SetCanMove(true); 
        dialogueText.text = ""; 
        exitButton.gameObject.SetActive(false); 
    }
}