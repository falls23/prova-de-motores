using System;
using UnityEngine;

public class player : personagem
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
   
    private bool andando=false;
    public Transform arma;

    public  GameObject Arma1;
    public  GameObject Arma2;



 
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
            Arma1.SetActive(false);
            Arma2.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
            Arma1.SetActive(true);
            Arma2.SetActive(false);
            }
           if (Input.GetKey(KeyCode.F))
           {

           }

        }
       
        
     animator.SetBool("Andando", andando);
        
    }


    
    }
    
