using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Estadisticas : MonoBehaviour
{
    public GameObject botonMenosDefensaFisica;
    public GameObject botonMasDefensaFisica;
    public Text textDefensaFisica;

    public GameObject botonMenosDefensaMagica;
    public GameObject botonMasDefensaMagica;
    public Text textDefensaMagica;

    public GameObject botonMenosDanyoFisico;
    public GameObject botonMasDanyoFisico;
    public Text textDanyoFisico;

    public GameObject botonMenosDanyoMagico;
    public GameObject botonMasDanyoMagico;
    public Text textDanyoMagico;

    public GameObject botonMenosMana;
    public GameObject botonMasMana;
    public Text textMana;

    public GameObject botonMenosVitalidad;
    public GameObject botonMasVitalidad;
    public Text textVitalidad;

    public GameObject botonMenosSuerte;
    public GameObject botonMasSuerte;
    public Text textSuerte;




    private float defensaFisicaBase = 0;
    private float defensaMagicaBase = 0;
    private float danyoFisicoBase = 0;
    private float danyoMagicoBase = 0;
    private float manaBase = 0;
    private float vitalidadBase = 0;
    private float suerteBase = 0;


    private float defensaFisicaVar;
    private float defensaMagicaVar;
    private float danyoFisicoVar;
    private float danyoMagicoVar;
    private float manaVar;
    private float vitalidadVar;
    private float suerteVar;

    private float defensaFisicaTotal;
    private float defensaMagicaTotal;
    private float danyoFisicoTotal;
    private float danyoMagicoTotal;
    private float manaTotal;
    private float vitalidadTotal;
    private float suerteTotal;

    private float p_defensaFisica;
    private float p_defensaMagica;
    private float p_danyoFisico;
    private float p_danyoMagico;
    private float p_mana;
    private float p_vitalidad;
    private float p_suerte;

    private float nivel;
    private float puntosUsados;
    private float puntosDisponibles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PuntoMasDefensaFisica()
    {
        p_defensaFisica++;
        puntosUsados++;
        puntosDisponibles--;
        
    }
    public void PuntoMenosDefensaFisica()
    {
        p_defensaFisica--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasDefensaMagica()
    {
        p_defensaMagica++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosDefensaMagica()
    {
        p_defensaMagica--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasDanyoFisico()
    {
        p_danyoFisico++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosDanyoFisico()
    {
        p_danyoFisico--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasDanyoMagico()
    {
        p_danyoMagico++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosDanyoMagico()
    {
        p_danyoMagico--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasMana()
    {
        p_mana++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosMana()
    {
        p_mana--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasVitalidad()
    {
        p_vitalidad++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosVitalidad()
    {
        p_vitalidad--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void PuntoMasSuerte()
    {
        p_suerte++;
        puntosUsados++;
        puntosDisponibles--;

    }
    public void PuntoMenosSuerte()
    {
        p_suerte--;
        puntosUsados--;
        puntosDisponibles++;

    }

    public void Nivel(float a)
    {
        nivel = a;
    }

    public void MostrarBotones()
    {
        if(puntosDisponibles> 0)
        {
            botonMasDanyoFisico.SetActive(true);
            botonMasDanyoMagico.SetActive(true);
            botonMasDefensaFisica.SetActive(true);
            botonMasDefensaMagica.SetActive(true);
            botonMasMana.SetActive(true);
            botonMasVitalidad.SetActive(true);
            botonMasSuerte.SetActive(true);
        }
        else
        {
            botonMasDanyoFisico.SetActive(false);
            botonMasDanyoMagico.SetActive(false);
            botonMasDefensaFisica.SetActive(false);
            botonMasDefensaMagica.SetActive(false);
            botonMasMana.SetActive(false);
            botonMasVitalidad.SetActive(false);
            botonMasSuerte.SetActive(false);
        }
        // para poder desactivar y activar el boton de restar puntos
        if (true)
        {
            if (p_danyoFisico > 0) 
            {
                botonMenosDanyoFisico.SetActive(true);
            }
            else
            {
                botonMenosDanyoFisico.SetActive(false);
            }

            if (p_danyoMagico > 0)
            {
                botonMenosDanyoMagico.SetActive(true);
            }
            else
            {
                botonMenosDanyoMagico.SetActive(false);
            }
            if (p_defensaFisica > 0)
            {
                botonMenosDefensaFisica.SetActive(true);
            }
            else
            {
                botonMenosDefensaFisica.SetActive(false);
            }
            if (p_defensaMagica > 0)
            {
                botonMenosDefensaMagica.SetActive(true);
            }
            else
            {
                botonMenosDefensaMagica.SetActive(false);
            }
            if (p_mana> 0)
            {
                botonMenosMana.SetActive(true);
            }
            else
            {
                botonMenosMana.SetActive(false);
            }
            if (p_suerte> 0)
            {
                botonMenosSuerte.SetActive(true);
            }
            else
            {
                botonMenosSuerte.SetActive(false);
            }
            if (p_vitalidad > 0)
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
       // puntosMaxDisponibles++;
    }

    public void ActualizarEstadisticas()
    {
        
        defensaFisicaTotal = defensaFisicaBase + defensaFisicaVar + p_defensaFisica*2;
        defensaMagicaTotal = defensaMagicaBase + defensaMagicaVar + p_defensaMagica*2;
        danyoFisicoTotal   = danyoFisicoBase + danyoFisicoVar + p_danyoFisico;
        danyoMagicoTotal   = danyoMagicoBase + danyoMagicoVar + p_danyoMagico;
        manaTotal           = manaBase  + manaVar + p_mana*120;
        vitalidadTotal      = vitalidadBase + vitalidadVar +p_vitalidad * 10;
        suerteTotal     = suerteBase +suerteVar + p_suerte;
    }
}
