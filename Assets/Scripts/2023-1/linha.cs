using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linha : MonoBehaviour
{
    public float velodalinha;
    public Rigidbody2D linharb, gelorb;
    private Vector3 posinicial;
    [SerializeField] private bool fimdireita = false;

    void Start()
    {
        posinicial = transform.position;
        linharb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        linharb.velocity = new Vector2 (velodalinha,0f);
        if (velodalinha>0 && fimdireita)
        {
            Instantiate (gameObject,posinicial,gameObject.transform.rotation);
            Destroy(gameObject,2);
            
            // fimdireita = false;
        }

    }

    void OnTriggerEnter2D (Collider2D parede)
    {
        if (parede.gameObject.tag == "dir")
        {
            fimdireita = true;
            Debug.Log("direita");
        }
    }

        
}
