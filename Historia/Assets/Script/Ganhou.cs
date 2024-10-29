using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Ganhou : MonoBehaviour
{
    public TMP_Text textoColetaveis;

    void Start()
    {
        if (textoColetaveis != null)
        {
            textoColetaveis.text = $"Colecionáveis: {ColecionavelUI.numeroColetaveis}/3";
        }
    }

    public void Recomeçar2()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}