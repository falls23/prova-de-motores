using System;
using UnityEngine;

public class player : personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
   
   private bool andando=false;
   public Transform arma;


 
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    
    void Update()
    {
        
        {    
            andando = false;

            if (arma.rotation.eulerAngles.z > -90 && arma.rotation.eulerAngles.z < 90)
            {
                spriteRenderer.flipX = false;
            }
            
            if (arma.rotation.eulerAngles.z > 90 && arma.rotation.eulerAngles.z < 270)
            {
                spriteRenderer.flipX = true;
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(GetVelocidade()* Time.deltaTime, 0, 0); 
                andando = true;
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, GetVelocidade()* Time.deltaTime, 0);
                andando = true;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(GetVelocidade()* Time.deltaTime, 0, 0);
                andando = true;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0,GetVelocidade()* Time.deltaTime , 0);
                andando = true;
            }

            if (Input.GetKey(KeyCode.E))
            {
            
            }

            if (Input.GetKey(KeyCode.K))
            {
            
            }
        }
       
    }

    animator.SetBool("Andando", andando);
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Inimigo");
       {
           int vidas = Getvidas() -1;
           Setvidas(vidas);
       }
       
    }
    
}
