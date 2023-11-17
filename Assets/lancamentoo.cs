using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lancamentoo : MonoBehaviour
{
    public Vector3 velocidade_inicial, gravidade, posicao_inicial;
    public float tempo, angulo, velocidade;
    bool atira;


    void Start()
    {
        tempo = 0f;
        posicao_inicial = transform.position;
        gravidade = new Vector3(0f, -10f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            atira = true;
        }
        if (atira)
        {
            tempo +=  Time.deltaTime;
            angulo = transform.eulerAngles.z * Mathf.Deg2Rad;
            velocidade_inicial.x = velocidade * Mathf.Cos(angulo);
            velocidade_inicial.y = velocidade * Mathf.Sin(angulo);
            velocidade_inicial.z = 0f;
            transform.position = posicao_inicial + velocidade_inicial * tempo + gravidade * tempo * tempo / 2;
        }
        if (transform.position.y < posicao_inicial.y)
        {
            atira = false;
        }
    }
}
