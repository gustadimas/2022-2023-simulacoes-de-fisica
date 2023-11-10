using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHS : MonoBehaviour
{
    
public float v_ang,raio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       transform.position = new Vector3 (raio * Mathf.Cos(v_ang*2*Mathf.PI*Time.fixedTime),8 + raio * Mathf.Sin(v_ang*2*Mathf.PI*Time.fixedTime),0f);
      
    }
}
