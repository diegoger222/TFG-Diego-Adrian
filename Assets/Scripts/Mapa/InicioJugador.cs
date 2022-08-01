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
        if (salidaJugadorAnterior == "Muerto")
        {
           
            Instantiate(ControladorPersonaje.Instance.gameObject, transform.position, Quaternion.identity);
            Vector3 a = ControladorPersonaje.Instance.puntoRevivir;
            ControladorPersonaje.Instance.gameObject.transform.position = a;
            ControladorPersonaje.Instance.gameObject.GetComponent<BarraDeVida>().CuraTotal();
        } else {
            for (int i = 0; i < puntosAsociados.Count; i++)
            {
                if (puntosAsociados[i] == salidaJugadorAnterior)
                {
                    Instantiate(ControladorPersonaje.Instance.gameObject, puntosAparicion[i].transform.position, Quaternion.identity);
                    ControladorPersonaje.Instance.gameObject.transform.position = puntosAparicion[i].transform.position;
                }
            }
        }
       
     
       
    }
}
