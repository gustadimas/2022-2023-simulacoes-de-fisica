using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grana : MonoBehaviour
{
    public GameObject granas, lugardagrana, player;
    public Transform granastransform;
    private float tempo,delay,n,velo;
    
    void Update()
    {
        tempo += Time.deltaTime;
        delay = 3;
    
        if(tempo>delay)
        {
         tempo = 0;
         Instantiate(granas,granastransform.position,granastransform.rotation);
         n = Random.Range(-8,8);
         lugardagrana.transform.position = new Vector3 (n,velo,0f);
        }
    }
}