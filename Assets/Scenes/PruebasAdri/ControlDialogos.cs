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
    private bool animacion;
    Textos dialogo;
    [SerializeField] Image imagenCara;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        colaDialogos = new Queue<string>();
    }
    public void ActivarDialogo (Textos dialogo, Sprite imagenCara, Sprite prota)
    {
        this.imagenCara.sprite = imagenCara;
        this.personajeInteractuable = imagenCara;
        this.prota = prota;
        animacion = true;
        anim.SetBool("Dialogo", true);
        this.dialogo = dialogo;
    }

    public void ActivaFrase()
    {
        animacion = false;
        colaDialogos.Clear();
        foreach (string frase in dialogo.arrayTextos)
        {
            colaDialogos.Enqueue(frase);
        }
        string fraseActual = colaDialogos.Dequeue();
        StartCoroutine(MostrarCaracteres(fraseActual));
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CerrarDialogo();
            return;
        }
        if (imagenCara.sprite.Equals(prota))
        {
            imagenCara.sprite = personajeInteractuable;
        }
        else
        {
            imagenCara.sprite = prota;
        }
        string fraseActual = colaDialogos.Dequeue();
        StartCoroutine(MostrarCaracteres(fraseActual));
    }
    public void CerrarDialogo()
    {
        anim.SetBool("Dialogo", false);
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
                StopAllCoroutines();
                textoPantalla.text = "";
                SiguienteFrase();
            }
        }
    }
}
