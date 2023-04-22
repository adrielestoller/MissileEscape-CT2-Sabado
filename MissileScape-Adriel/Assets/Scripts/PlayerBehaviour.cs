using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    float velocidade = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, velocidade), ForceMode2D.Impulse);
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
            rb.rotation += 45f;
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            rb.rotation -= 45f;
    }
}
