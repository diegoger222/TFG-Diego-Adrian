using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public Animator anim;
    public AudioSource audio;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        audio = this.GetComponent<AudioSource>();
    }
    public void IniciarJuego()
    {
        anim.SetTrigger("FadeOut");
        audio.Stop();
    }

    public void CerrarJuego()
    {
        anim.SetTrigger("FadeOut");
        audio.Stop();
        StartCoroutine(cerrar());
    }

    private IEnumerator cerrar()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
