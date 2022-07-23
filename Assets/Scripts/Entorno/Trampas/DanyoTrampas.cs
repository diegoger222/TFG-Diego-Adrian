using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanyoTrampas : MonoBehaviour
{
    // Start is called before the first frame update

    public float danyo = 10;
    public bool danyoMagico = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            // float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            // this.gameObject.transform.parent.gameObject.GetComponent<EstadisticasEnemigo>().dayno;
            if (danyoMagico)
            {
                collision.gameObject.GetComponent<BarraDeVida>().RestarVidaMG(danyo);
            }
            else
            {
                collision.gameObject.GetComponent<BarraDeVida>().RestarVidaFisica(danyo);
            }
           
        }
    }
}
