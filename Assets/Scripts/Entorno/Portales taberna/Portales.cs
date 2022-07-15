using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portales : MonoBehaviour
{
    private Animator anim;
    private int NumPortal = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PortalGen()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 0);
        NumPortal = 0;
    }
    public void PortalAmarillo()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 1);
        NumPortal = 1;
    }
    public void PortalAzul()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 2);
        NumPortal = 2;
    }
    public void PortalMorado()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 3);
        NumPortal = 3;
    }
    public void PortalRojo()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 4);
        NumPortal = 4;
    }
    public void PortalVerde()
    {
        anim.SetTrigger("Reset");
        anim.SetInteger("NumPortal", 5);
        NumPortal = 5;
    }
}
