using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string NomeDaFase;
    [SerializeField] private GameObject painelOpçao;
    [SerializeField] private GameObject painelMenuPrincipal;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jogar()
    {
        SceneManager.LoadScene(NomeDaFase);
       
    }
    public void AbrirOpçao()
    {
        painelOpçao.SetActive(true);
        painelMenuPrincipal.SetActive(false);
    }
    public void FecharOpçao()
    {
        painelOpçao.SetActive(false);
        painelMenuPrincipal.SetActive(true);
    }
    
    public void Sair()
    {
        Application.Quit();
        print("saiu do jogo");
    }
}
