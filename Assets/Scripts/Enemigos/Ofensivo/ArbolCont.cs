using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolCont : MonoBehaviour
{

    private GameObject player;
   // [SerializeField] public Transform player;

    [SerializeField] private float distancia;
    public Vector3 puntoInicial;
    public float distanciaSegundoPunto;
    private Vector3 puntoFinal;
    public bool camina = false;
    
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float tiempoAccion = 10;
    private float tiempoAcccionAux;
    private float tiempoParada = 3;
    private float tiempoParadaAux;
    private bool objetivo = false;
    public Vector3 target;
    public bool miraDerecha = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        puntoInicial = transform.position;
        puntoFinal = new Vector3(puntoInicial.x + distanciaSegundoPunto, puntoInicial.y,puntoInicial.z);
        tiempoParadaAux = tiempoParada;
        target = puntoFinal;
        animator.SetTrigger("Caminar");

    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(transform.position, player.transform.position);
        animator.SetFloat("Distancia", distancia);
        if (camina && animator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            if (tiempoParadaAux > 0)
            {
                tiempoParadaAux -= Time.deltaTime;
            }
            else
            {
                LlegadaPuntos();
            }
        }
        

    }
    public void Girar(Vector3 objetivo)
    {
        if (transform.position.x < objetivo.x)
        {
            if (miraDerecha) 
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
            }
            //spriteRenderer.flipX = false;
           // transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            // spriteRenderer.flipX = true;
            // transform.rotation = Quaternion.Euler(0, -180, 0);
            if (miraDerecha)
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Arma")
        {

            float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            this.GetComponent<Vida>().RecibirDano(((int)danyo));
        }
    }

    public void LlegadaPuntos()
    {
        if(target.x == puntoInicial.x)
        {
            
            camina = false;
            target = puntoFinal;
            animator.SetTrigger("Caminar");
        }
        else if(target.x == puntoFinal.x)
        {
          
            camina = false;
            target = puntoInicial;
            animator.SetTrigger("Caminar");
        }
    }

    public void ResetCaminar()
    {
        tiempoParadaAux = tiempoParada;
        camina = true;
    }
    
}
