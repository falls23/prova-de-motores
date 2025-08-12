using System;
using UnityEngine;

public class Moeda : MonoBehaviour
{
   
    public int pontos = 0;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Moeda")
        {
           pontos++;
           other.gameObject.SetActive(false);
        }
    }
}
