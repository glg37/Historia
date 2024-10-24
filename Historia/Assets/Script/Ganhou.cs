using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ganhou : MonoBehaviour
{
  




   public void Recomeçar2()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
   public void VoltarMenu()
    {
        SceneManager.LoadScene("Ganhou");
    }
}
