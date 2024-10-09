using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    
 
    public void Recomeçar()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
