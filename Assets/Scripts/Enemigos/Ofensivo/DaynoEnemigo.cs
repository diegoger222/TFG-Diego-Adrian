using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaynoEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            // float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            // this.gameObject.transform.parent.gameObject.GetComponent<EstadisticasEnemigo>().dayno;
            collision.gameObject.GetComponent<BarraDeVida>().RestarVidaFisica(this.gameObject.transform.parent.gameObject.GetComponent<EstadisticasEnemigo>().dayno);
        }
    }
}
