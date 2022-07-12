using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarEfecto : MonoBehaviour
{
    private Vector2 direction;
    public float speed;
    private Animator anim;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoPersonaje>().Direccion())
        {
            direction = new Vector2(1f, 0f);
        }
        else
        {
            direction = new Vector2(-1f, 0f);
            this.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

    void Update()
    {
        rb2d.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            rb2d.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("Hit");
        }
    }
}
