using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    // Start is called before the first frame update
    public Image barraVida;
    private Animator m_animator;
    public float vidaActual = 50;
    public GameObject pantallaMuerte;
    public float vidaMaxima = 100;
    private float vidaVar =100;
    public bool invencible = false;
    public Vector3 puntorevivir;
    public string escenaRevivir;
    private float damage;
    public Text text_poti;
    private int n_poti; //Potis actuales
    private int m_poti; //maximo potis
    private int ndefensa;
    public Image im_poti;
    [SerializeField] bool m_noBlood = false;
    //imagenfull poti a menos llena
    private float auxt;
   // [SerializeField] private float tiempoInmune;
  //  private float tiempoInmuneaux;
    private bool escudo = false;

    // Update is called once per frame
    void Update()
    {
        vidaVar = this.gameObject.GetComponent<Estadisticas>().GetVitalidad();
        vidaMaxima = vidaVar;
        barraVida.fillAmount = vidaActual / vidaMaxima;
        /* 
         if (Input.GetKeyDown("g"))
         {

             RestarVida(10);

         }
         /*
         if (Input.GetKeyDown("2"))
         {

             MorePotis(1);

         }
         */
        //Curarse "frasco estus" (mando)
        /*
        if (Input.GetButtonDown("Curarse"))
        {
            if (n_poti > 0)
            {
                RestarVida(-10);
                n_poti -= 1;
                text_poti.text = n_poti.ToString();
                ActualizarImagenPoti();
            }
        }
        /*
        if (tiempoInmuneaux > 0)
        {
            tiempoInmuneaux -= Time.deltaTime;
        }
        else
        {
            escudo = false;
        }
        */
    }

    private void Start()
    {
        m_animator = GetComponent<Animator>();
       // n_poti = 4;
       // m_poti = 4;
       

    }

    public void RestarVida(float cantidad)
    {
        //damage = cantidad;
        if (escudo)
        {
            this.gameObject.GetComponent<DanyoVisible>().BlockDa();
            escudo = false;
        }
        else if (!invencible )// && vidaActual > 0
        {
     

            vidaActual -= cantidad;
            this.gameObject.GetComponent<DanyoVisible>().MostrarDanyo(cantidad);
            // StartCoroutine(FrenarNasus());
            m_animator.SetTrigger("Danyo");
            if (vidaActual  <= 0)
            {
                //sonidoJugador.StopPlayAllSounds();
               // m_animator.SetBool("noBlood", m_noBlood);
               // m_animator.SetTrigger("Death");
             //   this.GetComponent<HeroKnight_Modi>().MuerteP(false);
             //   Invoke("Muerte", 2f);
                
              
                Debug.Log("Has muerto");
                Muerte();


            }
            if (vidaActual > vidaMaxima)
            {
                vidaActual = vidaMaxima;
            }
        }
    }
    //parte de las potis
    public void RestarVidaFisica(float cantidad)
    {
        //damage = cantidad;
        if (escudo)
        {
            this.gameObject.GetComponent<DanyoVisible>().BlockDa();
            escudo = false;
        }
        else if (!invencible && vidaActual > 0)
        {
            float cantidadAux = Calculoarmadura((int)cantidad);

            vidaActual -= cantidadAux;
            // StartCoroutine(FrenarNasus());
            m_animator.SetTrigger("Danyo");
            this.gameObject.GetComponent<DanyoVisible>().MostrarDanyo(cantidadAux);
            if (vidaActual <= 0)
            {
                Debug.Log("Has muerto");
                Muerte();
            }
            if (vidaActual > vidaMaxima)
            {
                vidaActual = vidaMaxima;
            }
        }
    }
    public void RestarVidaMG(float cantidad)
    {
        //damage = cantidad;
        if (escudo)
        {
            this.gameObject.GetComponent<DanyoVisible>().BlockDa();
            escudo = false;
        }
        else if(!invencible && vidaActual > 0 && !escudo)
        {
            float cantidadAux = CalculoResistenciaMG((int)cantidad);

            vidaActual -= cantidadAux;
            // StartCoroutine(FrenarNasus());
             m_animator.SetTrigger("Danyo");
            this.gameObject.GetComponent<DanyoVisible>().MostrarDanyo(cantidadAux);
            if (vidaActual <= 0)
            {
                Debug.Log("Has muerto");
                Muerte();
            }
            if (vidaActual > vidaMaxima)
            {
                vidaActual = vidaMaxima;
            }
        }
    }

    public void sumarVidaPoti(float cantidad)
    {
        vidaActual += cantidad;
        if (vidaActual > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
    }
    public void ActivarInmune()
    {
       // tiempoInmuneaux = tiempoInmune;
        escudo = true;
    }

    public void DesactivarInmune()
    {
        escudo = false;
    }
    public void MorePotis(int numero)
    {
        n_poti += numero;
        m_poti += numero;
        text_poti.text = n_poti.ToString();
       // ActualizarImagenPoti();
    }
    public void RecuperarPotis()
    {
        n_poti = m_poti;
      //  ActualizarImagenPoti();
    }

    /*
    public void ActualizarImagenPoti()
    {
        float a_n = n_poti;
        float a_m = m_poti;
        float a = a_n / a_m;
        if(a == 1f)
        {
            im_poti.sprite = b1;
        }else if (a >= 0.75f)
        {
            im_poti.sprite = b2;
        }else if(a>= 0.5f)
        {
            im_poti.sprite = b3;
        }else if (a > 0f)
        {
            im_poti.sprite = b4;
        }else if (a==0f)
        {
            im_poti.sprite = b5;
        }
    }
    */


    
  /*  private void Muerte()
    {
        auxt = Time.timeScale;
       // Time.timeScale = 0;
        Invoke("Teletrans", 2f);
    }
  */

    private void Teletrans()
    {
        Time.timeScale = auxt;
      //  this.gameObject.transform.position = puntorevivir.transform.position;
     //   this.GetComponent<HeroKnight_Modi>().MuerteP(true);
        vidaActual = 100;
        m_animator.SetTrigger("Hurt");
    }

    public void SumarPuntosVida(int puntos)
    {
        float a = puntos;
        vidaMaxima += a;
    }
    private int Calculoarmadura(int cantidad)
    {
        float armaduraAux = this.gameObject.GetComponent<Estadisticas>().GetArmadura();
        float daynoAux = (float)cantidad;
        float daynototal = daynoAux * (1 - (armaduraAux / ((100 + armaduraAux))));
        return (int)daynototal;
    }
    private int CalculoResistenciaMG(int cantidad)
    {
        float rMG= this.gameObject.GetComponent<Estadisticas>().GetResistenciaMG();
        float daynoAux = (float)cantidad;
        float daynototal = daynoAux * (1 - (rMG / (100 + rMG)));
        return (int)daynototal;
    }
    public void SumarPuntosDefensa(int puntos)
    {
        ndefensa += puntos;
    }

    public void SetSpawn(GameObject _spawn)
    {
      
        puntorevivir  = new Vector3(_spawn.transform.position.x, _spawn.transform.position.y + 2, this.gameObject.transform.position.z);
        ControladorPersonaje.Instance.puntoRevivir = puntorevivir;
        escenaRevivir = SceneManager.GetActiveScene().name;
    }


    IEnumerator FrenarNasus() {
        invencible = true;
        yield return new WaitForSeconds(0.75f);   
        invencible = false;
    }

   public void Muerte()
    {
        // this.gameObject.GetComponent<MovimientoPersonaje>().SetVivo(false);
        MuerteTP();
    }


    public void MuerteTP()
    {
        if(SceneManager.GetActiveScene().name == escenaRevivir)
        {
            this.gameObject.transform.position = puntorevivir;
            vidaActual = vidaMaxima;
            this.gameObject.GetComponent<MovimientoPersonaje>().SetVivo(true);
        }
        else
        {
            ControladorPersonaje.Instance.salidaJugador = "Muerto";
            SceneManager.LoadScene(escenaRevivir);
        }
    }

    public void CuraTotal()
    {
        vidaActual = vidaMaxima;
    }

   
}
