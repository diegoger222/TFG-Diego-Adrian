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


    [Header("Raros")]
    public AudioSource ayaya;

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




            case "ayaya": ayaya.Play();
                break;
            default:
                break;
        }
    }
}
