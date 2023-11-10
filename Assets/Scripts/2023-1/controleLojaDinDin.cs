using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controleLojaDinDin : MonoBehaviour
{
   public GameObject loja;
   bool LojaAtiva;
   public GameObject BotaoEntrarLoja;
   
    // Start is called before the first frame update
    void Start()
    {
        loja.SetActive(false);
        LojaAtiva = false;   
        
    }

    // Update is called once per frame
    void Update()
    {
      if(!LojaAtiva)
      {
       BotaoEntrarLoja.SetActive(true);
      }
      if(LojaAtiva)
      {
       BotaoEntrarLoja.SetActive(false);
      }
    }

    public void EntrarLoja()
    {
        loja.SetActive(true);
        LojaAtiva = true;
    }
    public void SairLoja()
    {
        loja.SetActive(false);
        LojaAtiva = false;
    }
}