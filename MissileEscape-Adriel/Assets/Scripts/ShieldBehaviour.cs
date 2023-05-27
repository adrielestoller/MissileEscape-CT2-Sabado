using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : ItemController
{
    LifeController vidaPlayer;

    void Awake()
    {
        Destroy(gameObject, this.tempoVida);
        vidaPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<LifeController>();
    }

    public override void Coletar()
    {
        Debug.Log("Escudo coletado!");
        this.Destruir();
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            this.Coletar();
        }
    }
}
