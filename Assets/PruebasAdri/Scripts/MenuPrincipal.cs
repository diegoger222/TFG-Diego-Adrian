using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public Animator anim;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    public void IniciarJuego()
    {
        anim.SetTrigger("FadeOut");
    }

    public void CerrarJuego()
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(cerrar());
    }

    private IEnumerator cerrar()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
