using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeInteractuable : MonoBehaviour
{
    public Textos[] dialogos;
    public int objetivos = 0;
    public Sprite imagenCara;
    public Sprite prota;
    private bool interactuar = false;
    private GameObject personaje;
    public GameObject bocadillo;
    private bool terminado = false;
    public string comprobador;
    public bool repetible;
    public bool aleatorio;

    public void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
        if(comprobador != null)
        {
            terminado = FindObjectOfType<ComprobadorMision>().GetVariable(comprobador);
        }
    }
    private void Update()
    {
        if (interactuar && Input.GetKeyDown("f"))
        {
            personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(true);
            interactuar = false;
            FindObjectOfType<ControlDialogos>().ActivarDialogo(dialogos[objetivos], dialogos[objetivos].soltar, imagenCara, prota);
            if (aleatorio)
            {
                int random = Random.Range(1, dialogos.Length + 1);
                objetivos = random;
            }
            else
            {
                objetivos++; 
                if (objetivos == dialogos.Length)
                {
                    if (comprobador != null)
                    {
                        FindObjectOfType<ComprobadorMision>().MisionTerminada(comprobador);
                    }
                    if (!repetible)
                    {
                        terminado = true;
                    }
                    objetivos %= dialogos.Length;
                }
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !terminado)
        {
            bocadillo.SetActive(true);
            interactuar = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bocadillo.SetActive(false);
            interactuar = false;
        }
    }
}
