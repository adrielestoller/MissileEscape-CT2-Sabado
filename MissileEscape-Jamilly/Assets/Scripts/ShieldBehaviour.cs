using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : ItemController
{
   void Awake()
   {
       Destroy(gameObject, this.tempoVida);
   }
   public override void Coletar()
   {
    Debug.Log("Escudo coletado!");
    this.Destruir();
   }

   public void OnTriggerEnter2D(Collider2D collider)
   {
     if(collider.gameObject.CompareTag("Player"))
     {
        this.Coletar();
     }
   }
}
