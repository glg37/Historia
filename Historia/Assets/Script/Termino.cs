using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Termino : MonoBehaviour
{
    public void Jogar3()
    {
        SceneManager.LoadScene("Jogo");
        Time.timeScale = 1;
    }
    IEnumerator fuego()
    {
        yield return new WaitForSeconds(17);
        SceneManager.LoadScene("Jogo");
    }

}