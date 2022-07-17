using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    private BoxCollider2D m_collider;
    private Animator m_animator;
    private Rigidbody2D m_body2d;
    public Image vida;
    public  float vida_Max = 100;
    private float vida_Act;
    private bool vivo;
    private int armadura;
    
    public AudioSource deathSound;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_collider = GetComponent<BoxCollider2D>();
        m_body2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

        vivo = true;
       
        vida_Act = vida_Max;

       // Debug.Log(gameObject.name);
        armadura = gameObject.GetComponent<EstadisticasEnemigo>().armadura;
    }

    // Update is called once per frame
    void Update()
    {
        vida.fillAmount = vida_Act / vida_Max;

        if(vida_Act <= 0)
        {
           
            
            m_body2d.constraints = RigidbodyConstraints2D.FreezePositionY;
            m_collider.enabled = false;
        }
    }

    public void RecibirDano(int cantidad)
    {
        
        
        int daynoT = calculoarmadura(cantidad);
        this.gameObject.GetComponent<DanyoVisible>().MostrarDanyo(daynoT);
        vida_Act -= daynoT;
        if(vida_Act <= 0)
        {
            m_animator.SetTrigger("Muerte");
           // deathSound.Play();
           // Invoke("Muerte", 2f);
        }
        else
        {
            m_animator.SetTrigger("Danyo");
            
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
   

}
