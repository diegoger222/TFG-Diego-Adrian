using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarNumero : MonoBehaviour
{
    Text numero;
    void Start()
    {
        numero = GetComponent<Text>();
    }

    public void TextUpdate(float number)
    {
        int aux = (int) number + 80;
        numero.text = aux + "";
    }
}
