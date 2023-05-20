using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : ItemController
{
   [SerializeField]
   int valor;

   void Awke()
   {
      Destroy(gameObject, this.tempoVida);
   }

   public override void Coletar()
   {
       Debug.Log("coletou a moeda!");
       this.Destruir();
   }

   void OnTriggerEnter2D(Collider2D collider)
   {
      if (collider.gameObject.CompareTag("Player"))
      {
           this.Coletar();
      }
   }
   
}
