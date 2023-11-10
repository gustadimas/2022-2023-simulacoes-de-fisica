using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMPUXO : MonoBehaviour
{
    public Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(0f,7));
    }
}
