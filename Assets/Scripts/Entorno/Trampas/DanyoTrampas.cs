using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanyoTrampas : MonoBehaviour
{
    public float danyo = 10;
    public bool danyoMagico = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
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
