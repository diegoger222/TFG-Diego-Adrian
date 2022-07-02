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

    public void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (interactuar && Input.GetKeyDown("r"))
        {
            personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(true);
            objetivos = objetivos % dialogos.Length;
            FindObjectOfType<ControlDialogos>().ActivarDialogo(dialogos[objetivos], imagenCara, prota);
            interactuar = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bocadillo.SetActive(true);
            interactuar = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bocadillo.SetActive(false);
            interactuar = false;
        }
    }
}
