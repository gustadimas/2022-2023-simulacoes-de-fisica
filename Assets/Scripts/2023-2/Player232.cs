using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player232 : MonoBehaviour
{
    public float x, y, x0, y0, v0x, v0y, ax, ay, t;
    void Start()
    {
       
    }

    void Update()
    {
        float sinalx = Input.GetAxisRaw("Horizontal");
        float sinaly = Input.GetAxisRaw("Vertical");
        if (sinalx == 0 && sinaly == 0)
        {
            t = 0;
            x0 = transform.position.x;
            y0 = transform.position.y;
        }
            if (sinalx !=0 || sinaly!=0)
        {
            
            
            t += Time.deltaTime;
            
            x = x0 + sinalx * v0x * t + ax * t * t / 2;
            y = y0 + sinaly * v0y * t + ay * t * t / 2;
            transform.position = new Vector3(x, y, 0f);
        }
        
    }
}
