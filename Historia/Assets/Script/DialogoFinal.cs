using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class DialogoFinal : MonoBehaviour
{
    [Header("Dialogo")]
    public GameObject dialogUI;
    public TMP_Text dialogText;
    [TextArea]
    public List<string> dialogLines;

    [Header("Botões")]
    public Button proximoButton;
    public Button exitButton;

    private int currentLineIndex = 0;

    private void Start()
    {
        dialogUI.SetActive(false);
        proximoButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);

        proximoButton.onClick.AddListener(NextLine);
        exitButton.onClick.AddListener(ExitDialog);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogUI.SetActive(true);
            proximoButton.gameObject.SetActive(true);
            Time.timeScale = 0;
            currentLineIndex = 0; 
            ShowLine();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FinalDialogo2();
        }
    }

    private void ShowLine()
    {
        if (currentLineIndex < dialogLines.Count)
        {
            dialogText.text = dialogLines[currentLineIndex];
        }
        else
        {
           
            proximoButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(true);
        }
    }

    public void NextLine()
    {
        currentLineIndex++;
        ShowLine();
    }

    private void ExitDialog()
    {
        FinalDialogo2();
        SceneManager.LoadScene("Ganhou");
    }

    private void FinalDialogo2()
    {
        dialogUI.SetActive(false);
        proximoButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}   