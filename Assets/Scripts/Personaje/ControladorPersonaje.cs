using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    // Start is called before the first frame update

    public static ControladorPersonaje Instance;
    public Vector3 puntoRevivir;
    public string salidaJugador;

    private void Awake()
    {
        if (ControladorPersonaje.Instance == null)
        {
            ControladorPersonaje.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public  string GetSalidaAnterior()
    {
        return salidaJugador;
    }
}
