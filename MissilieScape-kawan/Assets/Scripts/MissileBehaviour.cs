using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehaviour : MonoBehaviour
{
    Transform player;
    Rigidbody2D rb;
    TrailRenderer trail;
    [SerializeField]
    float velocidade, rotacao, tempo;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        trail = GetComponentInChildren<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo > 0)
        {
            if (player != null)
            {
                Vector2 direcao = (Vector2)player.position - rb.position;
                direcao.Normalize();

                float angulo = -Vector3 .Cross(direcao, transform.up).z;

                rb.angularVelocity = -angulo * rotacao;
                rb.velocity= transform.up * velocidade;
            }
        }
        else
        {
            DestroyMissile();
        }

        tempo-= Time.deltaTime;
    }
 
    public void DestroyMissile()
    {
        gameObject.GetComponent<SpriteRenderer>(). enabled = false;
        trail.enabled = false;

        Destroy (gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.CompareTag("Missile"))
      {
        DestroyMissile();
      }
    }
    
}