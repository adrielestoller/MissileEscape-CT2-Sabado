using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
      Rigidbody2D rb;

      [SerializeField]
      float velocidade, rotacao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
{
    rb.velocity = transform.up * velocidade;
}
    void Update()
    {
      transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * rotacao);
    }
}
