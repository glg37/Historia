using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Termino : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(fuego());
        Time.timeScale = 1;

    }

    IEnumerator fuego()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene("Jogo");

    }
    public void Skip()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
}



