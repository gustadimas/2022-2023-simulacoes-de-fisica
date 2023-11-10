using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematica : MonoBehaviour
{
   public Vector3 Vmedia;
   public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        tempo = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vmedia * Time.deltaTime;
        tempo += Time.deltaTime;

    }
}
