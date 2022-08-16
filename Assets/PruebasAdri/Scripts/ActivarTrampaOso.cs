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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetTrigger("Trap");
        }
    }
}
