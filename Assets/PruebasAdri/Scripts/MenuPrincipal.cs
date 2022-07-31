using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    private Animator anim;
    private AudioSource audio;
    public GameObject settings;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        audio = this.GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settings.SetActive(false);
        }
    }

    public void IniciarJuego()
    {
        anim.SetTrigger("FadeOut");
        audio.Stop();
        SceneManager.LoadScene("Saco");
    }

    public void Opciones()
    {
        settings.SetActive(true);
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
