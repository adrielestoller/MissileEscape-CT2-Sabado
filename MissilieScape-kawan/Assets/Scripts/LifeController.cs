using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField]
    bool temEscudo;
    
    GameObject escudo;
    void Update()
    {
        escudo.SetActive(temEscudo);
    }

    public void AddEscudo()
    {
        temEscudo = true;
    }

     public void delEscudo()
     {
        temEscudo = false;
     }
     void Morrer()
     {
        ganeObgect.SetActive(false);
        Time.timeScale = 0f;
     }
     private void OnTriggerEnter2D(Collide2D collider)
     {
        if (collider.gameObgect.CompareTag("Missele"))
        {
            collider.gameobgect.Getcomponet<MissileBehaviour>().DestroyMissile();
            if (temEscudo)
            {
                delEscudo();
            }
            else
            {
                Morrer();
            }
        }
    }
}
















































































