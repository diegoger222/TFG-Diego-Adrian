using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float m_velocidadCaminando = 4.0f;
    [SerializeField] float m_velocidadCorriendo = 4.0f;
    [SerializeField] float m_fuerzaSalto= 7.5f;
    [SerializeField] float m_fuerzaRodar = 6.0f;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoRodar = 3f;
    [SerializeField] private float tiempoEscudoActivado = 5f;
    [SerializeField] private float tiempoEscudoEnfriamiento = 15f;


    [SerializeField] private float tiempoSiguienteAtaque;
    [SerializeField] private float tiempoRodarAux; 
    [SerializeField] private float tiempoEscudoActivadoAux;
    [SerializeField] private float tiempoEscudoEnfriamientoAux;

    public Transform comprobadorSuelo;
    public GameObject escudo;

    private Animator m_animator;
    private Animator escudo_animator;
    private Rigidbody2D m_body2d;
    private BoxCollider2D m_collider;

    public LayerMask mascaraSuelo;

    private int e_cuentaAtaque = 0;
    private bool e_vivo = true;
    private bool e_espada = false;
    private bool e_aire = false;
    public bool e_cayendo = false;
    private bool e_escudo = false;
    private bool e_suelo = true;
    private bool m_atacando = false;
    private float m_direccionMirando = 1;
    private float inputX = 0;


    private bool aux_caida = false;
    void Start()
    {
        m_animator= GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_collider = GetComponent<BoxCollider2D>();
        escudo_animator = escudo.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        e_suelo = Physics2D.OverlapCircle(comprobadorSuelo.position, 0.07f, mascaraSuelo);
    }

    // Update is called once per frame
    void Update()
    {
        if (e_vivo)
        {
            inputX = Input.GetAxis("Horizontal");
          
            DireccionMirando();
            EstadoAireSuelo();
            if (inputX == 0)
            {
                m_animator.SetBool("Correr", false);
            }
            else
            {
                MoverseCorriendo();
            }

            if (Input.GetButtonDown("Saltar") && e_suelo){
                Saltar();
            }
            if (Input.GetButtonDown("Fire1") && (e_espada || !e_suelo) && tiempoSiguienteAtaque <= 0)
            {
                Ataque();
            }
            if (Input.GetButtonDown("Fire2") && (e_suelo) && tiempoEscudoEnfriamientoAux <= 0 && tiempoEscudoActivadoAux <=0)
            {
                escudo.SetActive(true);           
                tiempoEscudoActivadoAux = tiempoEscudoActivado;
                e_escudo = true;
            }
            if (Input.GetKeyDown("q"))
            {
                m_animator.SetTrigger("AtaqueE");
            }
            if (Input.GetKeyDown("e"))
            {
                EspadaActDes();
            }

            



            if (e_suelo)
            {
                aux_caida = false;
            }
            if (e_escudo)
            {
                if(tiempoEscudoActivadoAux <= 0)
                {
                    escudo.GetComponent<Animator>().SetTrigger("Desactivar");
                    tiempoEscudoEnfriamientoAux = tiempoEscudoEnfriamiento;
                    e_escudo = false;
                    Invoke("DesactivarEscudo", 3f);
                }
            }
            if (tiempoSiguienteAtaque > 0)
            {
                tiempoSiguienteAtaque -= Time.deltaTime;
            }
            if (tiempoRodarAux > 0)
            {
                tiempoRodarAux -= Time.deltaTime;
            }
            if(tiempoEscudoActivadoAux> 0)
            {
                tiempoEscudoActivadoAux -= Time.deltaTime;
            }
            if(tiempoEscudoEnfriamientoAux > 0)
            {
                tiempoEscudoEnfriamientoAux -= Time.deltaTime;
            }

        }
    }







    //Este metodo cambia el renderizado del sprite del personaje para que mire hacia el lado en el que se mueve el personaje
    public void DireccionMirando()
    {
        if(inputX > 0 && !m_atacando)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            m_direccionMirando = 1;
        }else if(inputX < 0 && !m_atacando)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            m_direccionMirando = -1;
        }
    }


    public void MoverseCaminando()
    {
        m_body2d.velocity = new Vector2(inputX * m_velocidadCaminando, m_body2d.velocity.y);
    }

    public void MoverseCorriendo()
    {
        m_body2d.velocity = new Vector2(inputX * m_velocidadCorriendo, m_body2d.velocity.y);
        m_animator.SetBool("Correr", true);
        if (Input.GetKeyDown("h"))
        {
            Rodar();
        }
    }

    //Activar y desactivar la espada
    public void EspadaActDes()
    {
        if (m_animator.GetBool("Espada"))
        {
            m_animator.SetBool("Espada", false);
            e_espada = false;
        }
        else
        {
            m_animator.SetBool("Espada", true);
            e_espada = true;
        }
        
    }

    public void Saltar()
    {
        m_animator.SetTrigger("Saltar");
        m_body2d.velocity = new Vector2(m_body2d.velocity.x, m_fuerzaSalto);
        
    }

    public void EstadoAireSuelo()
    {
        if (e_suelo)
        {
            e_aire = false;
            e_cayendo = false;
            m_animator.SetBool("Caer", false);
        }
        else
        {
            e_aire = true;
            if(m_body2d.velocity.y < 0)
            {
                e_cayendo = true;
                if (!aux_caida)
                {
                    m_animator.SetTrigger("CaerAux");
                   
                    aux_caida = true;
                }
                m_animator.SetBool("Caer", true);

            }
            else
            {
                e_cayendo = false;
                m_animator.SetBool("Caer", false);
            }
        }
    }

    public void Ataque()
    {

        tiempoSiguienteAtaque = tiempoEntreAtaques;
        if (e_cuentaAtaque == 0)
        {
            e_cuentaAtaque = 1;
            m_animator.SetTrigger("Ataque1");
        }
        else
        {
            e_cuentaAtaque = 0;
            m_animator.SetTrigger("Ataque2");
        }
    }


    public void Rodar()
    {
        //Aqui ira estamina
        m_animator.SetTrigger("Rodar");
        tiempoRodarAux = tiempoRodar;
        m_body2d.velocity = new Vector2(m_direccionMirando * m_fuerzaRodar, m_body2d.velocity.y);
    }

    public void DesactivarEscudo()
    {
        escudo.SetActive(false);
    }
}
