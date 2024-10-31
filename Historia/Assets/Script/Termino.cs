using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Termino : MonoBehaviour
{
    public void Jogar3()
    {
        StartCoroutine(fuego());
        Time.timeScale = 1;
    }

    IEnumerator fuego()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Jogo");
    }
    public void Jogar6()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
   
    
}