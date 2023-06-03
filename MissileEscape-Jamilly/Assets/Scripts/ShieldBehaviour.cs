using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : ItemController
{
   LifeController Vidaplayer;

   void Awake()
{
     Destroy(gameObject, this.tempoVida);
     Vidaplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<LifeController>();
}

public override void Coletar()
{
    Debug.Log("Escudo coletado!");
    this.Destruir();
}

 private void OnTriggerEnter2D(Collider2D collider)
 {
     if (collider.gameObject.CompareTag("Player"))
     {
         this.Coletar();
     }
 }
}