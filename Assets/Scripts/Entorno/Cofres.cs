using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofres : MonoBehaviour
{
    // Start is called before the first frame update
    public enum TipoCofre
    {
        Madera,
        Hierro,
        Oro,
        Diamante
    }
    public TipoCofre tipo;
    [Header("Hierro")]
    public GameObject[] hierro;
    [Header("Bronce")]
    public GameObject[] bronce;
    [Header("Oro")]
    public GameObject[] oro;
    [Header("Platino")]
    public GameObject[] platino;
    [Header("Legendaria")]
    public GameObject[] legendaria;
    [Header("Reliquia")]
    public GameObject[] reliquia;
    private bool dropDisponible = true;
    private Animator anim;
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CofreMadera()
    {
        int numRandom = Random.Range(1, 101);


        if (numRandom <= 70)
        {
            DropHierro();
        }
        else if(numRandom <= 90)
        {
            DropBronce();
        }
        else if(numRandom <= 100)
        {
            DropOro();
        }
    }

    public void CofreHierro()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom <= 50)
        {
            DropHierro();
        }
        else if (numRandom <= 80)
        {
            DropBronce();
        }
        else if (numRandom <= 95)
        {
            DropOro();
        }
        else if (numRandom <= 100)
        {
            DropPlatino();
        }
    }

    public void CofreOro()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom <= 30)
        {
            DropHierro();
        }
        else if (numRandom <= 55)
        {
            DropBronce();
        }
        else if (numRandom <= 75)
        {
            DropOro();
        }
        else if (numRandom <= 90)
        {
            DropPlatino();
        }
        else if(numRandom <= 97)
        {
            DropLegendario();
        }
        else if(numRandom <= 100)
        {
            DropReliquia();
        }
    }
    public void CofreDiamante()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom <= 10)
        {
            DropBronce();
        }
        else if (numRandom <= 25)
        {
            DropOro();
        }
        else if (numRandom <= 55)
        {
            DropPlatino();
        }
        else if (numRandom <= 80)
        {
            DropLegendario();
        }
        else if(numRandom <= 100)
        {
            DropReliquia();
        }
    }

    public void DropHierro()
    {
        int numRandom = Random.Range(0, hierro.Length);
        GameObject objecto = Instantiate(hierro[numRandom], gameObject.transform.position , Quaternion.identity); //+ Random.onUnitSphere
    }
    public void DropBronce()
    {
        int numRandom = Random.Range(0, bronce.Length );
        GameObject objecto = Instantiate(bronce[numRandom], gameObject.transform.position, Quaternion.identity); //+ Random.onUnitSphere


    }
    public void DropOro()
    {
        int numRandom = Random.Range(0, oro.Length);
        GameObject objecto = Instantiate(oro[numRandom], gameObject.transform.position, Quaternion.identity); //+ Random.onUnitSphere
    }
    public void DropPlatino()
    {
        int numRandom = Random.Range(0, platino.Length);
        GameObject objecto = Instantiate(platino[numRandom], gameObject.transform.position, Quaternion.identity); //+ Random.onUnitSphere
    }
    public void DropLegendario()
    {
        int numRandom = Random.Range(0, legendaria.Length);
        GameObject objecto = Instantiate(legendaria[numRandom], gameObject.transform.position, Quaternion.identity); //+ Random.onUnitSphere
    }
    public void DropReliquia()
    {
        int numRandom = Random.Range(0, reliquia.Length);
        GameObject objecto = Instantiate(reliquia[numRandom], gameObject.transform.position, Quaternion.identity); //+ Random.onUnitSphere
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Arma")
        {
            if (dropDisponible)
            {
                dropDisponible = false;
                switch (tipo.ToString())
                {
                    case "Madera":
                        CofreMadera();
                        anim.SetTrigger("Abrir");
                        break;
                    case "Hierro":
                        CofreHierro();
                        anim.SetTrigger("Abrir");
                        break;
                    case "Oro":
                        CofreOro();
                        anim.SetTrigger("Abrir");
                        break;
                    case "Diamante":
                        CofreDiamante();
                        anim.SetTrigger("Abrir");
                        break;
                }
            }
        }
    }
}
