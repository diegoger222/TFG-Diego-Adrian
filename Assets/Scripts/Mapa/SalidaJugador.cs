using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalidaJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public string escenaIR;
    public string nombreSalida;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            ControladorPersonaje.Instance.salidaJugador = nombreSalida;
            CambiarEscena();
        }
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(escenaIR);
    
    }
}
