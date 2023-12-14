using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    // Start is called before the first frame update
    public float ax,ay,vx,vy, A,w,t,fi;
    private Vector3 s0;
    void Start()
    {
        s0 = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t += Time.deltaTime;

        //GetComponent<Rigidbody2D>().velocity = new Vector2(vx, vy);
        //transform.position = s0 + new Vector3(vx, vy, 0f) * t; // MRU

        transform.position = new Vector3(transform.position.x + vx * Time.deltaTime, A * Mathf.Cos(w * t + fi), transform.position.z); //onda transversal
        //transform.position = new Vector3(-18+vx*t+ A * Mathf.Cos(w * t + fi), transform.position.y, 0f); // onda longitudinal

        /*if (transform.position.y > -0.9999)
        {
            float cos = Mathf.Cos(Mathf.PI / 6);
            float sen = Mathf.Sin(Mathf.PI / 6);
            transform.position = s0 + new Vector3(500*cos,500*sen, 0f) * t + new Vector3(0f,-10, 0f) * t * t / 2; // MRUA
        }*/
    }
}
