using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forca : MonoBehaviour
{
    public Rigidbody2D rb;
    public float tempo,forcax=0;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(forcax, 0f), ForceMode2D.Force);
        tempo += Time.deltaTime;
    }
}
