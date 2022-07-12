using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJefe : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float vida_Max;
    public Image vidaImagen;
    public Text vidaText;
    public GameObject generalVida;
    private BoxCollider2D m_collider;
    private Animator m_animator;
    private Rigidbody2D m_body2d;

    private float vidaActual;
    private int armadura;
    void Start()
    {
        vidaActual = vida_Max;
        vidaText.text = vidaActual.ToString() + "/" + vida_Max.ToString();
        armadura = gameObject.GetComponent<EstadisticasEnemigo>().armadura;
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vidaImagen.fillAmount = vidaActual / vida_Max;
        if (vidaActual <= 0)
        {


            m_body2d.constraints = RigidbodyConstraints2D.FreezePositionY;
            m_collider.enabled = false;
        }
    }

    public void RecibirDano(int cantidad)
    {
        int daynoT = calculoarmadura(cantidad);
        this.gameObject.GetComponent<DanyoVisible>().MostrarDanyo(daynoT);
        vidaActual -= daynoT;

        if (vidaActual <= 0)
        {
            m_animator.SetTrigger("Muerte");
            Invoke("DesactivarHudVida", 3);
            Invoke("Muerte", 2f);
            // this.GetComponent<Combate>().Muerto();
            vidaText.text = "0" + "/" + vida_Max.ToString();
            //deathSound.Play();
        }
        else
        {
            m_animator.SetTrigger("Dayno");
            vidaText.text = vidaActual.ToString() + "/" + vida_Max.ToString();
        }
    }

    private void Muerte()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Experiencia>().GanarExperiencia(20);
        this.gameObject.SetActive(false);
    }

    private int calculoarmadura(int cantidad)
    {
        float armaduraAux = (float)armadura;
        float daynoAux = (float)cantidad;
        float daynototal = daynoAux * (1 / (1 + (armaduraAux / 300)));
        return (int)daynototal;
    }
    public void ActivarHudVida()
    {
        generalVida.SetActive(true);
    }

    public void DesactivarHudVida()
    {
        generalVida.SetActive(false);
    }
}
