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

    public GameObject iUstats;
    public GameObject subirEstadisticas;
    public GameObject inventarioAct;

    private float defensaFisicaBase = 35;
    private float defensaMagicaBase = 20;
    private float danyoFisicoBase = 10;
    private float danyoMagicoBase = 5;
    private float manaBase = 100;
    private float vitalidadBase = 100;
    private float suerteBase = 0;


    private float defensaFisicaVar =0;
    private float defensaMagicaVar = 0;
    private float danyoFisicoVar = 0;
    private float danyoMagicoVar = 0;
    private float manaVar = 0;
    private float vitalidadVar = 0;
    private float suerteVar = 0;

    private float defensaFisicaTotal;
    private float defensaMagicaTotal;
    private float danyoFisicoTotal;
    private float danyoMagicoTotal;
    private float manaTotal;
    private float vitalidadTotal;
    private float suerteTotal;

    private float p_defensaFisica = 0;
    private float p_defensaMagica = 0;
    private float p_danyoFisico = 0;
    private float p_danyoMagico = 0;
    private float p_mana = 0;
    private float p_vitalidad = 0;
    private float p_suerte = 0;

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
        ActivarStats();
        if (iUstats.activeSelf)
        {
            ActualizarEstadisticas();
            if (subirEstadisticas.activeSelf)
            {
                MostrarBotones();
            }
        }
        
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
        if (iUstats.activeSelf)
        {
            ActualizarEstadisticasTexto();
        }
    }

    //Controlador de mostrar y ocultar estadisticas
    public void ActivarStats()
    {
        if (Input.GetButtonDown("MenuHabilidades"))
            if (iUstats.activeSelf)
                iUstats.SetActive(false);
            else
                iUstats.SetActive(true);
    }

    public void ActivarSubida()
    {
        if (subirEstadisticas.activeSelf)
        {
            subirEstadisticas.SetActive(false);
        }
        else
        {
            subirEstadisticas.SetActive(true);
        }
    }

    public void ActivarInventario()
    {
        if (inventarioAct.activeSelf)
        {
            inventarioAct.SetActive(false);
        }
        else
        {
            inventarioAct.SetActive(true);
        }
    }

    private void ActualizarEstadisticasTexto()
    {
        textDanyoFisico.text = "Fuerza:   " + danyoFisicoTotal.ToString();
        textDanyoMagico.text = "Inteligencía:   " + danyoMagicoTotal.ToString();
        textDefensaFisica.text = "Defensa Fisica:   " + defensaFisicaTotal.ToString();
        textDefensaMagica.text = "Defensa Magica:   " + defensaMagicaTotal.ToString();
        textSuerte.text = "Suerte:   " + suerteTotal.ToString();
        textMana.text = "Mana:   "+ manaTotal.ToString();
        textVitalidad.text = "Vitalidad:   "+vitalidadTotal.ToString();
    }

    public void SumarEstadisticas(ItemBuff _buff)
    {

        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (_buff == null)
        {

        }
        else if (_buff.attribute.ToString() == "Fuerza")
        {
            danyoFisicoVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "Inteligencia")
        {
            danyoMagicoVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "DefensaMagica")
        {
            defensaMagicaVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "DefensaFisica")
        {
            defensaFisicaVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "Suerte")
        {
            suerteVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "Mana")
        {
            manaVar += _buff.value;
        }
        else if (_buff.attribute.ToString() == "Vida")
        {
            vitalidadVar += _buff.value;
        }
        else
        {

        }

    }
    public void RestarEstadisticas(ItemBuff _buff)
    {

        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (_buff == null)
        {

        }
        else if (_buff.attribute.ToString() == "Fuerza")
        {
            danyoFisicoVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "Inteligencia")
        {
            danyoMagicoVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "DefensaMagica")
        {
            defensaMagicaVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "DefensaFisica")
        {
            defensaFisicaVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "Suerte")
        {
            suerteVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "Mana")
        {
            manaVar -= _buff.value;
        }
        else if (_buff.attribute.ToString() == "Vida")
        {
            vitalidadVar -= _buff.value;
        }
        else
        {

        }

    }

    public float  GetFuerza()
    {
        return danyoFisicoTotal;
    }
    public float GetInteligencia()
    {
        return danyoMagicoTotal;
    }
    public float GetArmadura()
    {
        return defensaFisicaTotal;
    }
    public float GetResistenciaMG()
    {
        return defensaMagicaTotal;
    }

    public float GetVitalidad()
    {
        return vitalidadTotal;
    }
    public float GetMana()
    {
        return manaTotal;
    }
    public float GetSuerte()
    {
        return suerteTotal;
    }
}
