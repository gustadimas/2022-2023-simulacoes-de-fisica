using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inelastica20222 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (10,0f);
        GetComponent<Rigidbody2D>().centerOfMass = new Vector2(0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
