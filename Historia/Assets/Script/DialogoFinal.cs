using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DialogoFinal : MonoBehaviour
{
    [Header("Dialogo")]
    public GameObject dialogUI;


 

    [Header("Botao")]
    public Button exitButton;


    
    private void Start()
    {
        dialogUI.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            dialogUI.SetActive(true);
            exitButton.gameObject.SetActive(true);
            Time.timeScale = 0; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            dialogUI.SetActive(false);
            exitButton.gameObject.SetActive(false);
            SceneManager.LoadScene("Ganhou");
        }
    }
}
