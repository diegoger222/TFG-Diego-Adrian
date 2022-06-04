using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosEstadisticas : MonoBehaviour
{


    private int puntosEnVida;
    private int puntosEnStamina;
    private int puntosEnDefensa;
    private int puntosEnDano;

    private int puntosDisponibles;
    private int puntosMaxDisponibles;
    private int puntosUsados;
    private float nivelact;
    public GameObject botonMenosVitalidad;
    public GameObject botonMasVitalidad;
    public GameObject botonMenosAguante;
    public GameObject botonMasAguante;
    public GameObject botonMenosFuerza;
    public GameObject botonMasFuerza;
    public GameObject player;
    public GameObject iUstats;
    public GameObject arma;

    public Text textVitalidad;
    public Text textAguante;
    public Text textFuerza;
    public Text textnivel;
    public Text textpuntos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        arma = GameObject.FindGameObjectWithTag("Arma");
        
        puntosDisponibles = 0;
        puntosMaxDisponibles = 0;
        puntosUsados = 0;
        puntosEnDano = 0;
        puntosEnStamina = 0;
        puntosEnVida = 0;
        puntosEnDefensa = 0;
        nivelact = 1;

        textAguante.text = puntosEnStamina.ToString();
        textVitalidad.text = puntosEnVida.ToString();
        textFuerza.text = puntosEnDano.ToString();
        textnivel.text = nivelact.ToString();
        textpuntos.text = puntosDisponibles.ToString();
        
      //  if()
    }

    // Update is called once per frame
    void Update()
    {

        ActivarStats();
        if (iUstats.activeSelf)
        {


            textAguante.text = puntosEnStamina.ToString();
            textVitalidad.text = puntosEnVida.ToString();
            textFuerza.text = puntosEnDano.ToString();
            textnivel.text = nivelact.ToString();
            textpuntos.text = puntosDisponibles.ToString();
            //si hay puntos disponibles
            if (puntosDisponibles> 0)
            {

                botonMasAguante.SetActive(true);
                botonMasFuerza.SetActive(true);
                botonMasVitalidad.SetActive(true);
            }
            else
            {
                botonMasAguante.SetActive(false);
                botonMasFuerza.SetActive(false);
                botonMasVitalidad.SetActive(false);
            }


            if(puntosEnDano > 0)
            {
                botonMenosFuerza.SetActive(true);
            }
            else
            {
                botonMenosFuerza.SetActive(false);
            }


            if(puntosEnStamina > 0)
            {
                botonMenosAguante.SetActive(true);
            }
            else
            {
                botonMenosAguante.SetActive(false);
            }

            if(puntosEnVida > 0)
            {
                botonMenosVitalidad.SetActive(true);
            }
            else
            {
                botonMenosVitalidad.SetActive(false);
            }

        }
    }

    public void SubirPuntos() //esta funcion es llamada desde Experiencia cuando se sube de nivel para a�adir puntos;
    {
        puntosDisponibles++;
        puntosMaxDisponibles++;
    }
    public void Nivel(float a)
    {
        nivelact = a;
    }
    public void ResetPuntos()
    {
        puntosDisponibles = puntosMaxDisponibles;
        puntosUsados = 0;
        if (puntosEnVida > 0)
        {
            player.GetComponent<BarraDeVida>().SumarPuntosVida(-puntosEnVida);
            puntosEnVida = 0;
        }
        if(puntosEnStamina > 0)
        {
            player.GetComponent<Stamina>().SumarPuntosStamina(-puntosEnStamina);
            puntosEnStamina = 0;
        }
        if(puntosEnDefensa > 0)
        {
            player.GetComponent<BarraDeVida>().SumarPuntosDefensa(-puntosEnDefensa);
            puntosEnDefensa = 0;
        }
        if(puntosEnDano > 0)
        {
            arma.GetComponent<Dano>().SumarDamage(-puntosEnDano);
            puntosEnDano = 0;
        }
    }





    public void PuntoMasVida()
    {
        puntosEnVida++;
        puntosUsados++;
        puntosDisponibles--;
        player.GetComponent<BarraDeVida>().SumarPuntosVida(1);
    }

    public void PuntoMenosVida()
    {
        puntosEnVida--;
        puntosUsados--;
        puntosDisponibles++;
        player.GetComponent<BarraDeVida>().SumarPuntosVida(-1);
    }

    public void PuntoMasStamina()
    {
        puntosEnStamina++;
        puntosUsados++;
        puntosDisponibles--;
        player.GetComponent<Stamina>().SumarPuntosStamina(1);
    }

    public void PuntoMenosStamina()
    {
        puntosEnStamina--;
        puntosUsados--;
        puntosDisponibles++;
        player.GetComponent<Stamina>().RestarEstamina(1);
    }

    public void PuntoMasDefensa()
    {
        puntosEnDefensa++;
        puntosUsados++;
        puntosDisponibles--;
        player.GetComponent<BarraDeVida>().SumarPuntosDefensa(1);
    }

    public void PuntoMenosDefensa()
    {
        puntosEnDefensa--;
        puntosUsados--;
        puntosDisponibles++;
        player.GetComponent<BarraDeVida>().SumarPuntosDefensa(-1);
    }

    public void PuntoMasFuerza()
    {
        puntosEnDano++;
        puntosUsados++;
        puntosDisponibles--;
        arma.GetComponent<Dano>().SumarDamage(1);
    }
    
    public void PuntoMenosFuerza()
    {
        puntosEnDano--;
        puntosUsados--;
        puntosDisponibles++;
        arma.GetComponent<Dano>().SumarDamage(-1);

    }
    //Menú de habilidades (mando).
    public void ActivarStats()
    {
        if (Input.GetButtonDown("MenuHabilidades"))
            if (iUstats.activeSelf)
                iUstats.SetActive(false);
            else
                iUstats.SetActive(true);
    }
    
}
