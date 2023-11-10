using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    public Rigidbody2D rb;
    public float tempo, forcay = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb.mass = Mathf.Sqrt(60);
        rb.AddForce(new Vector2(0f, forcay), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        tempo += Time.deltaTime;
    }
}
