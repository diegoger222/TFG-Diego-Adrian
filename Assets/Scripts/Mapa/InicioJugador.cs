using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public string salidaJugadorAnterior;

    public List<GameObject> puntosAparicion;
    public List<string> puntosAsociados;
    
    private void Start()
    {

        salidaJugadorAnterior = ControladorPersonaje.Instance.salidaJugador;
        for (int i = 0; i < puntosAsociados.Count; i++)
        {
            if (puntosAsociados[i] == salidaJugadorAnterior)
            {
                Instantiate(ControladorPersonaje.Instance.gameObject, puntosAparicion[i].transform.position, Quaternion.identity);
            }
        }
       
     
       
    }
}
