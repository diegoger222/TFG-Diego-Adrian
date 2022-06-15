using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlDialogos : MonoBehaviour
{
    private Animator anim;
    private Queue<string> colaDialogos;
    private Sprite prota;
    private Sprite personajeInteractuable;
    private bool animacion = true;
    Textos dialogo;
    [SerializeField] Image imagenCara;
    [SerializeField] TextMeshProUGUI textoPantalla;
    private GameObject personaje;

    public void Start()
    {
        textoPantalla.text = "";
        anim = this.GetComponent<Animator>();
        colaDialogos = new Queue<string>();
        personaje = GameObject.FindGameObjectWithTag("Player");
    }
    public void ActivarDialogo (Textos dialogo, Sprite imagenCara, Sprite prota)
    {
        textoPantalla.text = "";
        this.imagenCara.sprite = imagenCara;
        this.personajeInteractuable = imagenCara;
        this.prota = prota;
        animacion = true;
        anim.SetBool("Dialogo", true);
        this.dialogo = dialogo;
    }

    public void ActivaFrase()
    {
        colaDialogos.Clear();
        textoPantalla.text = "";
        animacion = false;
        foreach (string frase in dialogo.arrayTextos)
        {
            colaDialogos.Enqueue(frase);
        }
        string fraseActual = colaDialogos.Dequeue();
        StartCoroutine(MostrarCaracteres(fraseActual));
    }

    public void SiguienteFrase()
    {
        StopAllCoroutines();
        textoPantalla.text = "";
        if (colaDialogos.Count == 0)
        {
            CerrarDialogo();
            return;
        }
        if (!dialogo.monologo)
        {
            if (imagenCara.sprite.Equals(prota))
            {
                imagenCara.sprite = personajeInteractuable;
            }
            else
            {
                imagenCara.sprite = prota;
            }
        }
        string fraseActual = colaDialogos.Dequeue();
        StartCoroutine(MostrarCaracteres(fraseActual));
    }
    public void CerrarDialogo()
    {
        textoPantalla.text = "";
        anim.SetBool("Dialogo", false);
        personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(false);
    }

    IEnumerator MostrarCaracteres (string fraseAmostrar)
    {
        textoPantalla.text = "";
        foreach (char caracter in fraseAmostrar.ToCharArray())
        {
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.03f);
        }
    }
    public void Update()
    {
        if (!animacion)
        {
            if (Input.GetKeyDown("r"))
            {
                SiguienteFrase();
            }
        }
    }
}
