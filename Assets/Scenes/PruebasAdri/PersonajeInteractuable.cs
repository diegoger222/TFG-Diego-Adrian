using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeInteractuable : MonoBehaviour
{
    public Textos dialogos;
    public Sprite imagenCara;
    public Sprite prota;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ControlDialogos>().ActivarDialogo(dialogos, imagenCara, prota);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<ControlDialogos>().CerrarDialogo();
    }
}
