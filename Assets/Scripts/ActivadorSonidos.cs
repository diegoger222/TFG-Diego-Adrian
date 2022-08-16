using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorSonidos : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Sonidos Personaje")]
    public AudioSource per_ataque;
    public AudioSource per_rodar;
    public AudioSource per_danyo;

    [Header("Sonidos Enemigos")]
    public AudioSource enm_ataque1;
    public AudioSource enm_ataque2;
    public AudioSource enm_ataque1d;
    public AudioSource enm_ataque2d;
    public AudioSource enm_danyo;


    [Header("Raros")]
    public AudioSource ayaya;

    [Header("EfectosArma")]
    public AudioSource Bat;
    public AudioSource Blood;
    public AudioSource Earth;
    public AudioSource Explosion;
    public AudioSource Feather;
    public AudioSource Fire;
    public AudioSource Galaxy;
    public AudioSource Ice;
    public AudioSource Katana;
    public AudioSource Light;
    public AudioSource Lightning;
    public AudioSource Poison;
    public AudioSource PoisonB;
    public AudioSource Rapier;
    public AudioSource Re;
    public AudioSource Si;
    public AudioSource Sol;
    public AudioSource Solar;
    public AudioSource Soul;
    public AudioSource Souls;
    public AudioSource Thunder;
    public AudioSource WaterB;
    public AudioSource WaterSplash;
    public AudioSource WaterSplash2;
    public AudioSource WaterTornado;
    public AudioSource Wind;
    public AudioSource Wood;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarSonido(string _sonido)
    {
        switch (_sonido)
        {
            case "per_ataque": per_ataque.Play();
                break;
            case "enm_ataque1": enm_ataque1.Play();
                break;
            case "enm_ataque2": enm_ataque2.Play();
                break;
            case "enm_ataque1d":
                enm_ataque1d.Play();
                break;
            case "enm_ataque2d":
                enm_ataque2d.Play();
                break;
            case "enm_danyo":
                enm_danyo.Play();
                break;
            case "Bat": Bat.Play();
                break;
            case "Blood": Blood.Play();
                break;
            case "Earth": Earth.Play();
                break;
            case "Explosion": Explosion.Play();
                break;
            case "Feather": Feather.Play();
                break;
            case "Fire": Fire.Play();
                break;
            case "Galaxy": Galaxy.Play();
                break;
            case "Ice": Ice.Play();
                break;
            case "Katana": Katana.Play();
                break;
            case "Light": Light.Play();
                break;
            case "Lightning": Lightning.Play();
                break;
            case "Poison": Poison.Play();
                break;
            case "PoisonB": PoisonB.Play();
                break;
            case "Rapier": Rapier.Play();
                break;
            case "Re": Re.Play();
                break;
            case "Si": Si.Play();
                break;
            case "Sol": Sol.Play();
                break;
            case "Solar": Solar.Play();
                break;
            case "Soul": Soul.Play();
                break;
            case "Souls": Souls.Play();
                break;
            case "Thunder": Thunder.Play();
                break;
            case "WaterB": WaterB.Play();
                break;
            case "WaterSplash": WaterSplash.Play();
                break;
            case "WaterSplash2": WaterSplash2.Play();
                break;
            case "WaterTornado": WaterTornado.Play();
                break;
            case "Wind": Wind.Play();
                break;
            case "Wood": Wood.Play();
                break;
            case "ayaya": ayaya.Play();
                break;
            default:
                break;
        }
    }
    public void DesactivarSonido(string _sonido)
    {
        switch (_sonido)
        {
            case "Earth": Earth.Stop();
                break;
            case "Fire": Fire.Stop();
                break;
            case "Galaxy": Galaxy.Stop();
                break;
            case "Ice": Ice.Stop();
                break;
            case "Light": Light.Stop();
                break;
            case "Lightning": Lightning.Stop();
                break;
            case "PoisonB": PoisonB.Stop();
                break;
            case "Soul": Soul.Stop();
                break;
            case "WaterB": WaterB.Stop();
                break;
            case "Wind": Wind.Stop();
                break;
            case "Wood": Wood.Stop();
                break;
            default:
                break;
        }
    }
}
