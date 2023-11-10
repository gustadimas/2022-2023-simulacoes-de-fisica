using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().centerOfMass = new Vector2(0f,0f);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(100,0f),ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
