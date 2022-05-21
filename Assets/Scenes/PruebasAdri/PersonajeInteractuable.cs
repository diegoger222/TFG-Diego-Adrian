using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeInteractuable : MonoBehaviour
{
    public Textos dialogos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ControlDialogos>().ActivarDialogo(dialogos);
    }
}
