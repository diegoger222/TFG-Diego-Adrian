using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogos : MonoBehaviour
{
    private Animator anim;
    private Queue<string> colaDialogos;
    Textos dialogo;
    [SerializeField] TextMeshProUGUI textoPantalla;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        colaDialogos = new Queue<string>();
    }
    public void ActivarDialogo (Textos dialogo)
    {
        anim.SetBool("Dialogo", true);
        this.dialogo = dialogo;
    }

    public void ActivaTexto()
    {
        colaDialogos.Clear();
        foreach (string textoGuardar in dialogo.arrayTextos)
        {
            colaDialogos.Enqueue(textoGuardar);
        }
            SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if(colaDialogos.Count == 0)
        {
            CierraDialogo();
            return;
        }
        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
        StartCoroutine(MostrarCaracteres(fraseActual));
    }
    void CierraDialogo()
    {
        anim.SetBool("Dialogo", false);
    }

    IEnumerator MostrarCaracteres (string textoAmostrar)
    {
        textoPantalla.text = "";
        foreach (char caracter in textoAmostrar.ToCharArray())
        {
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SiguienteFrase();
        }
    }
}
