using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUV : MonoBehaviour
{
   public float x0,v0x,ax,t,y0,v0y,ay,g,e;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        ay = g;
        transform.position = new Vector3(x0 + v0x*t + ax*t*t/2,y0 + v0y*t + ay*t*t/2,0f);
    }
}
