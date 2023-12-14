using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float velocidade,aceleracao,impulso,t,timer;
    public float tempo = 0;
    public int pontos, valor;
    private Vector3 sinal;
    public Rigidbody2D rb,rg;
    public Animator animar;
    public GameObject grana;
    private bool pulando = false;
    private bool pegou = false;
    public Text ponto_mostrado;
    
    // Start is called before the first frame update, anta verde, roxa e amarela kkkkkk
    void Start()
    {
        velocidade = 5.33f;
        impulso = 122;
        valor = 1;
        rg = grana.GetComponent<Rigidbody2D>();
        rg.gravityScale = 0.4f;
        timer = 0;
    }

    // Update is called once per frame, caneta azuuuul
    void anda() {
        sinal = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += sinal*velocidade*Time.deltaTime + sinal*aceleracao*Time.deltaTime*Time.deltaTime/2;
         
        if(Input.GetAxis("Horizontal") < 0f) {
            transform.eulerAngles = new Vector3 (0f,180,0f);
        }
        if(Input.GetAxis("Horizontal") > 0f)  {
            transform.eulerAngles = new Vector3 (0f,0f,0f);
        }
    }
    void pula() {
    
        if (Input.GetKeyDown(KeyCode.Space) && !pulando) {
           rb.AddForce(new Vector2(0,impulso),ForceMode2D.Impulse);
        }
        
    }
    void coleta(){
         if (pegou == true){
           
            pontos += valor;
            pegou = false;
            ponto_mostrado.text = pontos.ToString();

        }

    }

    void Update()  {

        t += Time.deltaTime;
       
        anda();
        pula();
        coleta();
        ponto_mostrado.text = pontos.ToString();
        timer += Time.deltaTime;
        if (timer >= 20){
            rg.gravityScale += 0.1f;
            timer = 0;
        }


        if (Input.GetAxis("Horizontal")!=0) 
        {
           animar.SetBool("move" , true) ;
        
           /* if (tempo < 1.3f || aceleracao == 0)
            { tempo += Time.deltaTime;
            }
            else
            { tempo = 1.301f;
            } */       //o comentado é para limitar a velocidade caso aceleração dif de zero     
        }
        else
        {
           // tempo = 0;            
           animar.SetBool("move", false);
        }
                       
    }
    void OnCollisionEnter2D(Collision2D colide)
    {
        if(colide.gameObject.layer == 8) // está no chão
        {
                pulando = false;
        }
         if(colide.gameObject.layer == 12) //pegou a grana
        {
                pegou = true;
                 
        }
    }
    void OnCollisionExit2D(Collision2D colide)
    {
        if(colide.gameObject.layer == 8)
        {
             pulando = true;
        } 
    }
    //player mais veloz
    public void acelerar()
    {
        if(pontos >= 5)
        {
         velocidade += 0.22f;
         pontos -= 7;
        }
    }
    //player pula mais alto
    public void PuloAlto()
    {
        if(pontos >= 7)
        {
         impulso += 0.22f;
         pontos -= 5;
        }
    }
    public void dindinvalioso()
    {
       if(pontos >= 10)
       {
        valor += 1;
        pontos -= 10;
       }
    }

    public void granadevagar()
    {
        if (pontos >= 9)
        {
         rg.gravityScale = rg.gravityScale*0.9f;
         pontos -= 9;
        }
    }

}