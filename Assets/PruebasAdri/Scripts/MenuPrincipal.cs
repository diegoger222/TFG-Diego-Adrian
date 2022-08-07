using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    private Animator anim;
    private AudioSource audioSource;
    public GameObject settings;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
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
        audioSource.Stop();
        SceneManager.LoadScene("Saco");
    }

    public void Opciones()
    {
        settings.SetActive(true);
    }

    public void CerrarJuego()
    {
        anim.SetTrigger("FadeOut");
        audioSource.Stop();
        StartCoroutine(cerrar());
    }

    private IEnumerator cerrar()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
