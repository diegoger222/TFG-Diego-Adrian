using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanyoTrampas : MonoBehaviour
{
    // Start is called before the first frame update

    public float danyo = 10;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            // float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            // this.gameObject.transform.parent.gameObject.GetComponent<EstadisticasEnemigo>().dayno;
            collision.gameObject.GetComponent<BarraDeVida>().RestarVidaFisica(danyo);
        }
    }
}
