using System;
using UnityEngine;


public class personagem : MonoBehaviour
{
    [SerializeField]private int vidas= 10;
    [SerializeField]private int energia= 100;
    [SerializeField]private float velocidade= 5;
  
    
public void Setvidas(int vidas)
{
    this.vidas = vidas;
}

public int Getvidas()
{
    return this.vidas;
}

public int Setenergia(int energia)
{
 return this.energia;
}
 public int Getenergia()
 {
    return this.energia;
 }

 public void setVelocidade(int velocidade) => this.velocidade = velocidade;

 public float GetVelocidade()
 {
     return this.velocidade;
 }
 
 
 
}