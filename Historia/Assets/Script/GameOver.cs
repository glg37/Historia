using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    
 
    public void Recome�ar()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
