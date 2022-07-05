using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuervo : MonoBehaviour
{

    [SerializeField] public Transform player;

    [SerializeField] private float distancia;
    public Vector3 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float tiempoAccion = 10;
    private float tiempoAcccionAux;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        tiempoAcccionAux = tiempoAccion;
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(transform.position, player.position);
        animator.SetFloat("Distancia", distancia);
        tiempoAcccionAux -= Time.deltaTime;
        if(tiempoAcccionAux< 0)
        {
            animator.SetTrigger("Gritar");
            tiempoAcccionAux = tiempoAccion;
        }
    }
    public void Girar(Vector3 objetivo)
    {
        if( transform.position.x < objetivo.x)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
}
