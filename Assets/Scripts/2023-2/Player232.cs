using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player232 : MonoBehaviour
{
    public float x, y, x0, y0, v0x, v0y, ax, ay, t, v;
    public bool lancar = false;

    void Start()
    {
        x0 = transform.position.x;
        y0 = transform.position.y;
    }

    /*
    void Update() // AULA 01
    {
        float sinalx = Input.GetAxisRaw("Horizontal");
        float sinaly = Input.GetAxisRaw("Vertical");
        if (sinalx == 0 && sinaly == 0)
        {
            t = 0;
            x0 = transform.position.x;
            y0 = transform.position.y;
        }
        
        if (sinalx !=0 || sinaly!=0)
        {
            t += Time.deltaTime;
            
            x = x0 + sinalx * v0x * t + ax * t * t / 2;
            y = y0 + sinaly * v0y * t + ay * t * t / 2;
            transform.position = new Vector3(x, y, 0f);
        }
        
    } // Fim da AULA 01
    */

    void Update()  // AULA 02 {sintetizar aula 01 com script MUA}
    {
        float sinalx = Input.GetAxisRaw("Horizontal");
        float sinaly = Input.GetAxisRaw("Vertical");

        /* if (sinalx != 0 || sinaly != 0)
         {
             x = sinalx * v0x * Time.deltaTime;
             y = sinaly * v0y * Time.deltaTime;
             //transform.position = transform.position + new Vector3 (x, y, 0f);
             transform.Translate(x, y, 0f,Space.Self);
         } */

        if ((sinalx != 0 || sinaly != 0) && (!lancar))
        {
            x = sinalx * v0x * Time.deltaTime;
            y = sinaly * v0y * Time.deltaTime;
            //transform.position = transform.position + new Vector3 (x, y, 0f);
            transform.Translate(x, 0f, 0f, Space.World);
            transform.eulerAngles += new Vector3(0f, 0f, y);
            x0 = transform.position.x;
            y0 = transform.position.y;
            t = 0f;
        }
        if (!lancar && Input.GetKeyDown(KeyCode.Space))
        {
            v += 2;
            
            if (v > 50f)
            {
                v = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Input.GetKeyDown(KeyCode.Return))
        {     
            lancar = true;
            float ang = Mathf.Deg2Rad * transform.eulerAngles.z;
            v0x = v * Mathf.Cos(ang);
            v0y = v * Mathf.Sin(ang);
        }
        if (lancar)
        {
            t += Time.deltaTime;

            x = x0 + v0x * t;
            y = y0 + v0y * t - 5 * t * t;
            transform.position = new Vector3(x, y, 0f);
           
            if (y < -4)
            {
                lancar = false;
            }
        } // Exercício: Fazer Script para o objeto lançado atingir a cesta. Independe da posição inicial do objeto.
    } // Fim da AULA 02
}








