using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilarTp : MonoBehaviour
{
    // Start is called before the first frame update
    public string escenaIR;
    public string nombreSalida;
    public GameObject bocadillo;
    private bool interactuar;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(interactuar && Input.GetKeyDown("f"))
        {
            ControladorPersonaje.Instance.salidaJugador = nombreSalida;
            CambiarEscena();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bocadillo.SetActive(true);
            interactuar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bocadillo.SetActive(false);
            interactuar = false;
        }
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(escenaIR);
    }
}
