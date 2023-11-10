using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulo : MonoBehaviour
{
    
    [SerializeField] private float movespeed,jumpspeed,raylengh,pontos; 
    [SerializeField] private LayerMask groundlayer;  
    public Rigidbody2D playerrb;
    public SpriteRenderer linha11, linha12, linha13;
    private float moveinput;
    private byte n = 255;
    public bool isgrounded;
     
    //lol
    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        pontos = 0f;
    }

    //lil
    void Update()
    {
        HandleInput();
        HandleColision();
                
    }
    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleInput()
    {
        if (isgrounded && Input.GetKeyDown(KeyCode.DownArrow))
        {
            //desce
            StartCoroutine(Drop());

        }
        if (isgrounded)
        {
            moveinput = Input.GetAxisRaw("Horizontal");
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                jump();
            }
        }

    }

    void HandleColision()
    {
        float arx, ary;
        arx = transform.position.x;
        ary = transform.position.y - 0.4f;

        isgrounded = Physics2D.OverlapCircle(new Vector2(arx,ary), raylengh, groundlayer);
        

    }

    void jump ()
    {
        playerrb.velocity = new Vector2(playerrb.velocity.x,0f);
        playerrb.velocity += new Vector2(playerrb.velocity.x,jumpspeed);
        
    }

    void HandleMovement()
    {
        Vector2 velocidade;
        velocidade = new Vector2(moveinput*movespeed,playerrb.velocity.y);
        playerrb.velocity = velocidade;

    }
    private IEnumerator Drop()
    {
        //desliga as colisões entre as camadas no parênteses
        Physics2D.IgnoreLayerCollision(8,11,true);

        // esperar
        yield return new WaitForSeconds (.4f);

        // Ligar a colisão novamente
        Physics2D.IgnoreLayerCollision(8,11,false);

    }

    void OnTriggerEnter2D(Collider2D pisou)
    {
        if(pisou.gameObject.layer == 15)
        {
            pontos += 1;
            if (n == 255){
                n=0;
            }
            else{
                n=255;
            }
            linha11.color = new Color32(245,n,n,255);
            linha12.color = new Color32(245,n,n,255);
            linha13.color = new Color32(245,n,n,255);
            


        }
    }
}
