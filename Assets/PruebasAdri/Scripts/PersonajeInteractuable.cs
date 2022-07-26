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
    public bool terminado = false;

    public void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (interactuar && Input.GetKeyDown("f"))
        {
            personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(true);
            interactuar = false;
            FindObjectOfType<ControlDialogos>().ActivarDialogo(dialogos[objetivos], dialogos[objetivos].soltar, imagenCara, prota);
            objetivos++;
            if(objetivos == dialogos.Length)
            {
                terminado = true;
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
