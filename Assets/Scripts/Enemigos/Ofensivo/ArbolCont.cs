using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolCont : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Arma")
        {

            float danyo = player.GetComponent<Estadisticas>().GetFuerza();

            this.GetComponent<Vida>().RecibirDano(((int)danyo));
        }
    }
}
