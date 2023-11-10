using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centrodemassa : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
   

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    rb.centerOfMass = new Vector2(-0.5f,-0.5f);

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
