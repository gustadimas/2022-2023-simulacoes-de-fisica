using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(20,0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
