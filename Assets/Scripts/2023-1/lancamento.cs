using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lancamento: MonoBehaviour
{
    public float t=0,v0x,v0y;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(v0x,v0y);
            Invoke("Tempo",0.1f);
        }
    }
    void Tempo ()
    {
        t += 0.1f;
        Invoke("Tempo",0.1f);
    }
}