using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColecionavelUI : MonoBehaviour
{
    public GameObject Escudo;
    public Text texto;
    public int numeroColetaveis;

    // Start is called before the first frame update
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