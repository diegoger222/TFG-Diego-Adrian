using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobadorMision : MonoBehaviour
{
    public bool rey = false;
    public bool tutorial = false;
    public bool cocinero = false;
    public void MisionTerminada(string comprobador)
    {
        switch (comprobador)
        {
            case "rey":
                rey = true;
                break;
            case "tutorial":
                tutorial = true;
                break;
            case "cocinero":
                cocinero = true;
                break;
            default:
                break;
        }
    }

    public bool GetVariable(string variable)
    {
        switch (variable)
        {
            case "rey":
                return rey;
            case "tutorial":
                return tutorial;
            case "cocinero":
                return cocinero;
            default:
                return false;
        }
    }
}
