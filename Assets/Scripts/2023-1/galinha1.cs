using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galinha1 : MonoBehaviour
{
    private Vector3 sinal;
    public float velo_galinha;
    public int pontog1;
    public Animator animar;
    public GameObject rb;
    public Text verpontog1;
    public AudioSource audiog;
    public AudioClip pontua,andando;
    void Start()
    {
        audiog.volume = 0f; 
    }
    void anda() {
        
        if (Input.GetKeyDown(KeyCode.W)) {
            sinal = new Vector3(0f,1,0f);
            animar.SetBool("vai" , true) ;
            animar.SetBool("parou" , false) ;
            animar.SetBool("volta" , false) ;
            audiog.clip = andando;
            audiog.volume = 1f;
            audiog.Play();
            
        }
        if (Input.GetKeyDown(KeyCode.S)){
            sinal = new Vector3(0f,-1,0f);
            animar.SetBool("volta" , true) ;
            animar.SetBool("parou" , false) ;
            animar.SetBool("vai" , false) ;
            audiog.clip = andando;
            audiog.volume = 1f;
            audiog.Play();           
        }                          
               
        if(Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.W))  { 
            sinal = new Vector3(0f,0f,0f); 
            animar.SetBool("parou" , true) ; 
            audiog.volume = 0f;                     
            
        }
        transform.position += sinal*velo_galinha*Time.deltaTime;      
       
    }
    void Update()
    {
        anda();
    }
    void OnCollisionEnter2D(Collision2D colide)
    {
        if(colide.gameObject.layer == 9) // galinha pontua
        {
             audiog.PlayOneShot(pontua);
             rb.transform.position = new Vector3 (-5f,-4.6f,0f);  
             pontog1 += 1;
             verpontog1.text = pontog1.ToString();            
                         
        }
    }
    void OnTriggerEnter2D(Collider2D bateu)
    {
        if (bateu.gameObject.layer == 13)
        {
            rb.transform.position = new Vector3 (-5f,-4.6f,0f);
        }
        
    }
}