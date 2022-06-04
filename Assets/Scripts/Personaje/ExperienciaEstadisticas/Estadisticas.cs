using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas : MonoBehaviour
{

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

    public void SubirPuntos() //esta funcion es llamada desde Experiencia cuando se sube de nivel para a�adir puntos;
    {
        puntosDisponibles++;
       // puntosMaxDisponibles++;
    }
}
