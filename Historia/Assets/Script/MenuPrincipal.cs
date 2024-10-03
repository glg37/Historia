using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string NomeDaFase;
    [SerializeField] private GameObject painelOp�ao;
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
    public void AbrirOp�ao()
    {
        painelOp�ao.SetActive(true);
        painelMenuPrincipal.SetActive(false);
    }
    public void FecharOp�ao()
    {
        painelOp�ao.SetActive(false);
        painelMenuPrincipal.SetActive(true);
    }
    
    public void Sair()
    {
        Application.Quit();
        print("saiu do jogo");
    }
}
