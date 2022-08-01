using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreCuracion : MonoBehaviour
{
    // Start is called before the first frame update
    public bool repetible = true;
    private bool curaDisponible = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (curaDisponible)
            {
                collision.GetComponent<BarraDeVida>().CuraTotal();
            }
            if (!repetible)
            {
                curaDisponible = false;
            }
            
        }
    }
}
