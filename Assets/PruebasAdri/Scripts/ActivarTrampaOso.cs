using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTrampaOso : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("Trap");
        }
    }
}
