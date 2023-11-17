using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUA : MonoBehaviour
{
    public float t = 0;
    public Vector3 Vinicial, aceleracao, posicao_inicio;
    void Start()
    {
        posicao_inicio = transform.position;
    }

    void Update()
    {
      t += Time.deltaTime;
        transform.position = posicao_inicio + Vinicial * t + aceleracao * t * t / 2; 
    }
}
