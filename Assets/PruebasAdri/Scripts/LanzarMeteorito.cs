using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarMeteorito : MonoBehaviour
{
    private Vector2 direction;
    public float speed;
    private Animator anim;
    private Animator animChild;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        animChild = this.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoPersonaje>().Direccion())
        {
            direction = new Vector2(1f, -1f);
        }
        else
        {
            direction = new Vector2(-1f, -1f);
            this.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

    void Update()
    {
        rb2d.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            rb2d.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("Hit");
            animChild.SetTrigger("Hit");
        }
    }
}
