using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class granapf : MonoBehaviour
{
  public AudioSource audio;
  public GameObject lugardagrana;

    void Start() {
        audio.enabled = false;
    }
    void Update()
    {
      
    }
    
    void OnCollisionEnter2D (Collision2D collide) {
          if (collide.gameObject.layer == 8) {
           Destroy(gameObject, 0.02f);
        }
          if (collide.gameObject.layer == 11) {
           ColectAudio();
           Destroy(gameObject,0.02f);
          }
        
    }
    public void ColectAudio(){
       audio.enabled = true;
    }
    
}