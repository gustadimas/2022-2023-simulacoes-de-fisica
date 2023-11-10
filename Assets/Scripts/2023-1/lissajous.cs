using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lissajous : MonoBehaviour
{
    public float A,aa,B,ba,t,d;
    private float D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        D = d*Mathf.PI/180;
        //transform.position = new Vector3(A*Mathf.Sin(t*aa*Mathf.PI/180 ),B*Mathf.Sin(t*ba*Mathf.PI/180 + D),0);
        transform.position = new Vector3(A * Mathf.Cos(t * aa * Mathf.PI / 180), B * Mathf.Sin(t * ba * Mathf.PI / 180 ), 0f);
    }
}
