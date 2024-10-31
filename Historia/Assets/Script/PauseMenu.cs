using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Transform PausaMenu;

   

    public GameObject Pausado;

    public GameObject Continuar;

    public GameObject numero;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausaMenu.gameObject.activeSelf)
            {
                PausaMenu.gameObject.SetActive(false);
                Pausado.SetActive(false);
                numero.SetActive(true);
                Continuar.SetActive(false);
               
                Time.timeScale = 1;


            }
            else
            {

                Time.timeScale = 0;
                numero.SetActive(false);
                PausaMenu.gameObject.SetActive(true);
                Pausado.SetActive(true);
               
                Continuar.SetActive(true);
              
            }


        }
    }

    public void ContinuarGame()
    {
        if (PausaMenu.gameObject.activeSelf)
        {
            Time.timeScale = 1;
            numero.SetActive(true);
            PausaMenu.gameObject.SetActive(false);
            Pausado.SetActive(false);
           
            




        }
    }
   
    public void FecharOpçao()
    {
       
        PausaMenu.gameObject.SetActive(true);
        Time.timeScale = 0;

    }


    public void VoltarProMenu()
    {


        SceneManager.LoadScene("Menu");

    }
}







