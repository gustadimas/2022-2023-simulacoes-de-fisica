using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public float velocidade,tempo;
    public Rigidbody2D boneco;
    


    void Start()
    {
        tempo = 0;
    }

    // Update is called once per frame
   // void Update(){

    //}
    void FixedUpdate()
    {
       /* tempo += Time.deltaTime;
        Vector3 sinal = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += sinal*velocidade*Time.deltaTime; */

        boneco.velocity = new Vector2(2,0f);
        tempo += Time.deltaTime;

        /*boneco.AddForce (new Vector2(2,0f));
        tempo += Time.deltaTime;

        if (tempo > 7.99)
        {
            Time.timeScale = 0;
        }*/

    }
}
