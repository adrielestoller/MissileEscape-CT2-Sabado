using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField]
    GameObject missil;

    [SerializeField]
    float frequencia, contador;

    void Update()
    {
        if (contador < frequencia)
        {
            contador = Time.deltaTime;
        }
        else
        {
            spawn();
        }
    }

    void spawn()
    {
Vector2 spawnPos = Camera .main.ViewportToWorldPoint(
    new Vector2(
        Random.Range(-0.5f, 1.5f),
        Random.Range(-0.5f, 1.5f)
       )
    );

    Instantiate(missil, spawnPos, Quaternion.identity);
    contador = 0f;
 }
}
