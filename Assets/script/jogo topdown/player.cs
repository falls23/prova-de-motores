
using UnityEngine;
public class player : personagem
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(GetVelocidade()* Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, GetVelocidade()* Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(GetVelocidade()* Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0,GetVelocidade()* Time.deltaTime , 0);
            }

            if (Input.GetKey(KeyCode.E))
            {
            
            }

            if (Input.GetKey(KeyCode.K))
            {
            
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Inimigo");
       {
           int vidas = Getvidas() -1;
           Setvidas(vidas);
       }
       
    }
    
}
