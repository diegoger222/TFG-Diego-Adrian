using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAlmas : MonoBehaviour
{

    private bool arriba = true;
    private Vector2 direction = new Vector2(0f, 0f);
    private GameObject player;
    private Rigidbody2D rb2d;
    private float tiempoMov = 2f;
    private float tiempoMovAux;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb2d = GetComponent<Rigidbody2D>();
        tiempoMovAux = tiempoMov;
    }

    // Update is called once per frame
    void Update()
    {

        DireccionMirar();
        ContadorTiempo();
        transform.position = new Vector3( transform.position.x,transform.position.y + (direction * velocidad * Time.deltaTime).y);
      //  rb2d.velocity = direction * velocidad;
        
    }

    public void DireccionMirar()
    {
        if (player.GetComponent<MovimientoPersonaje>().Direccion())
        {
            this.transform.rotation = Quaternion.Euler(0, -180, 0);   
        }
        else
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void ActualizarMov()
    {
        if (arriba)
        {
            direction = new Vector2(0f, -1f);
            arriba = false;
            tiempoMovAux = tiempoMov;
        }
        else
        {
            direction = new Vector2(0f, 1f);
            arriba = true;
            tiempoMovAux = tiempoMov;
        }
    }
    public void ContadorTiempo()
    {
        tiempoMovAux -= Time.deltaTime;
        if(tiempoMovAux < 0)
        {
            ActualizarMov();
        }
    }
}
