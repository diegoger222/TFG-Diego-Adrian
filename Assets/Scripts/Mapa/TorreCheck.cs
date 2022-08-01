using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreCheck : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Animator torre;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        torre = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<BarraDeVida>().SetSpawn(gameObject);
            
            torre.SetTrigger("Activar");
        }
    }
}
