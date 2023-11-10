using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class momentum : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(2,0);
       rb.centerOfMass = new Vector2(0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
