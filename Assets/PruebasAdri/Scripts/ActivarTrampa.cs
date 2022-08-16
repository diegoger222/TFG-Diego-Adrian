using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTrampa : MonoBehaviour
{
    private Animator anim;
    private GameObject personaje;
    private float distancia;

    void Start()
    {
        anim = GetComponent<Animator>();
        personaje = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        distancia = Vector2.Distance(transform.position, personaje.transform.position);
        if(distancia < 5)
        {
            anim.SetTrigger("Trap");
        }
    }
}
