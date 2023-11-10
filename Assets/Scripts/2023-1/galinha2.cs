using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galinha2 : MonoBehaviour
{
    private Vector3 sinal;
    public float velo_galinha;
    public int pontog2;
    public Animator animar;
    public GameObject rb;
    public Text verpontog2;
    public AudioSource audiog;
    public AudioClip pontua,andando;
    void Start()
    {
        audiog.volume = 0f; 
    }
    void anda() {
         if (Input.GetKeyDown(KeyCode.UpArrow)) {
            sinal = new Vector3(0f,1,0f);
            animar.SetBool("vai" , true) ;
            animar.SetBool("parou" , false) ;
            animar.SetBool("volta" , false) ;
            audiog.clip = andando;
            audiog.volume = 1f;
            audiog.Play();            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            sinal = new Vector3(0f,-1,0f);
            animar.SetBool("volta" , true) ;
            animar.SetBool("parou" , false) ;
            animar.SetBool("vai" , false) ;
            audiog.clip = andando;
            audiog.volume = 1f;
            audiog.Play();           
        }           
        if(Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.UpArrow))  { 
            sinal = new Vector3(0f,0f,0f); 
            animar.SetBool("parou" , true) ; 
            audiog.volume = 0f;            
        }
        transform.position += sinal*velo_galinha*Time.deltaTime;   

    }
    // Update is called once per frame
    void Update()
    {
        anda();
    }
     void OnCollisionEnter2D(Collision2D colide)
    {
        if(colide.gameObject.layer == 9) // galinha pontua
        {
             
             audiog.PlayOneShot(pontua);
             rb.transform.position = new Vector3 (5f,-4.6f,0f);  
             pontog2 += 1;
             verpontog2.text = pontog2.ToString();
            
                  
        }
    }
    void OnTriggerEnter2D(Collider2D bateu)
    {
        if (bateu.gameObject.layer == 13)
        {
            rb.transform.position = new Vector3 (5f,-4.6f,0f);
        }
        
    }
}