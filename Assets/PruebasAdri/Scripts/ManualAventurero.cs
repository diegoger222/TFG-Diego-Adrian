using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManualAventurero : MonoBehaviour
{
    public Textos textIzq;
    public Textos textDcho;
    private Animator anim;
    [SerializeField] TextMeshProUGUI textoIzq;
    [SerializeField] TextMeshProUGUI textoDcho;
    public int contador;
    private GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        textoIzq.text = "";
        textoDcho.text = "";
        anim = this.GetComponent<Animator>();
        personaje = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CerrarManual();
        }
    }

    public void ActivarManual()
    {
        personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(true);
        contador = 0;
        textoIzq.text = textIzq.arrayTextos[contador];
        textoDcho.text = textDcho.arrayTextos[contador];
        anim.SetTrigger("Open");
    } 

    public void SiguientePagina()
    {
        if (contador != textIzq.arrayTextos.Length - 1)
        {
            contador = ++contador;
            anim.SetTrigger("NextPage");
        } 
    }

    public void AnteriorPagina()
    {
        if (contador != 0)
        {
            contador = --contador;
            anim.SetTrigger("PrevPage");
        }
    }

    public void CambiarTextoIzq()
    {
        textoIzq.text = textIzq.arrayTextos[contador];
    }

    public void CambiarTextoDer()
    {
        textoDcho.text = textDcho.arrayTextos[contador];
    }

    public void CerrarManual()
    {
        anim.SetTrigger("Close");
        contador = 0;
        textoDcho.text = "";
        textoIzq.text = "";
        anim.SetTrigger("Exit");
        personaje.GetComponent<MovimientoPersonaje>().EstadoDialogo(false);
    }
}
