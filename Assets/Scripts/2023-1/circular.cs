using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circular : MonoBehaviour
{
    public float veloang,raio,tempo,raio2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        transform.position = new Vector3 (20f + raio*Mathf.Cos(veloang*tempo),raio2*Mathf.Sin(veloang*tempo),0f);
    }
}
