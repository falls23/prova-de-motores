using System;
using UnityEngine;


public class personagem : MonoBehaviour
{
public int vidas;
public int energia;
public float velocidade;

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

 public float setVelocidade(int velocidade) => this.velocidade = velocidade;

 public float GetVelocidade()
 {
     return this.velocidade;
 }
 
 
 
}