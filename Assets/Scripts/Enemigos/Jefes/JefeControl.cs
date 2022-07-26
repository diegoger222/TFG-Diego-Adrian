using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeControl : MonoBehaviour
{
    private GameObject player;
    public Vector3 target;
    [SerializeField] private float distancia;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(transform.position, player.transform.position);
        animator.SetFloat("Distancia", distancia);
    }

    public void Girar(Vector3 objetivo)
    {
        if (transform.position.x < objetivo.x)
        {
                transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
                transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Arma")
        {

            float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            this.GetComponent<VidaJefe>().RecibirDano(((int)danyo));
        }
        if (collision.gameObject.tag == "EfectoArma")
        {
            float danyo = player.GetComponent<Estadisticas>().GetInteligencia();

            this.GetComponent<VidaJefe>().RecibirDanoMagico(((int)danyo));
        }
    }

}
