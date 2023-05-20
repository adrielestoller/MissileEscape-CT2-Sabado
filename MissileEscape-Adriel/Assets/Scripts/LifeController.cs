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

    public void delEscutd()
    {
        temEscudo = false;
    }
}
