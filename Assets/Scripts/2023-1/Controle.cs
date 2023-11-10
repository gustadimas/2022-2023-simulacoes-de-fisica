using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
   public float temporizador,minutos_de_jogo;
   public GameObject botao;
    void Start()
    {
        temporizador = 0f;
        botao.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
       
        temporizador += Time.deltaTime;
        if (temporizador >minutos_de_jogo*60)
        {
            Time.timeScale = 0;
            botao.SetActive(true);
        }
    
    }
    public void reiniciar (string lilname)
    {
        SceneManager.LoadScene(lilname);
        temporizador =0f;
        Time.timeScale = 1;

    }
}
