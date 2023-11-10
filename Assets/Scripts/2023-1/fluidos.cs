using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fluidos : MonoBehaviour
{
    public float y0,voy,g,acel,t;
    // Start is called before the first frame update
    void Start()
    {
        acel = g;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
       // transform.position = new Vector3 (0f,y0+voy*t+acel*t*t/2,0f); 

       
   

       
    }
}
