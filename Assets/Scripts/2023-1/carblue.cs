using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carblue : MonoBehaviour
{
  public Rigidbody2D rb;
  public float force;
  private Vector3 posinicio;
  
    void Start()
    {
        posinicio = transform.position;        
    }
    void Update()
    {
               
        rb.AddForce(new Vector2(force,0f));
        if (transform.position.x > 35)
        {
            transform.position = posinicio;
            rb.velocity = new Vector2 (0f,0f);
            force = Random.Range(0.1f,2f);            
        }
        if (transform.position.x < -20)
        {
            transform.position = posinicio;
            rb.velocity = new Vector2 (0f,0f);
            force = Random.Range(-1.5f,-0.1f);
        }
    }
    
    
}
