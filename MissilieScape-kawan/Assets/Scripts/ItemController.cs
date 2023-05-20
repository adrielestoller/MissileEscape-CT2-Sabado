using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemController : MonoBehaviour
{
    public float tempoVida;
    public abstract void Coletar();

   public void Destruir()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject, 1f);
    }
    
}
