using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancamento_Vertical : MonoBehaviour
{
    public float t=0,v0y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,v0y);
            Invoke("Tempo",0.1f);


        }

    }
    void Tempo (){
        t += 0.1f;
        Invoke("Tempo",0.1f);
    }
}
