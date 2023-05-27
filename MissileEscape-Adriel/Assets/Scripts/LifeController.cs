using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField]
    bool temEscudo;
    [SerializeField]
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
        gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Missile"))
        {
            collider.gameObject.GetComponent<MissileBehaviour>().DestroyMissile();

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
