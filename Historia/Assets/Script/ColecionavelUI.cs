using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColecionavelUI : MonoBehaviour
{
    public GameObject Escudo;
    public Text texto;
    public static int numeroColetaveis;

    void Start()
    {
        if (texto == null)
        {
            texto = GetComponent<Text>();
        }

        AtualizarTexto();
    }

    public void AtualizarTexto()
    {
        texto.text = $"{numeroColetaveis}/3";
    }

    public void ColetavelPegado()
    {
        numeroColetaveis++;
        AtualizarTexto();
    }
}