using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newton : MonoBehaviour
{
    public Vector3 forca;
    public Transform tp,tschao;
    public float a, t,tempo;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        a = (2 * (tschao.localScale.x)) / (t * t);
        forca = rb.mass * new Vector3(a, 0f,0f);
        //rb.AddForce(forca);
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(80, 0f));
        tempo += Time.deltaTime;
        Debug.Log(tempo);
    }
}
