using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehaviour : ItemController 
{
[SerializeField]
   int valor;

   void Awake()
    {
        Destroy(gameObject, this.tempoVida);
    }
    public override void Coletar()
    {
        Debug.Log("Coletou a moeda !");
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
 
