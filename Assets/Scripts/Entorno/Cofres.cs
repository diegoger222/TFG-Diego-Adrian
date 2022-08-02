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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CofreMadera()
    {
        int numRandom = Random.Range(1, 101);


        if (numRandom < 80)
        {
            DropBronce();
        }else if(numRandom <90){
            DropHierro();
        }else if(numRandom < 99)
        {
            DropOro();
        }else if(numRandom == 100)
        {
            DropPlatino();
        }

        
        //switch ()
    }

    public void CofreHierro()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom < 60)
        {
            DropBronce();
        }
        else if (numRandom < 70)
        {
            DropHierro();
        }
        else if (numRandom < 96)
        {
            DropOro();
        }
        else if (numRandom < 101)
        {
            DropPlatino();
        }
    }

    public void CofreOro()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom < 20)
        {
            DropBronce();
        }
        else if (numRandom < 45)
        {
            DropHierro();
        }
        else if (numRandom < 75)
        {
            DropOro();
        }
        else if (numRandom < 90)
        {
            DropPlatino();
        }else if(numRandom < 99)
        {
            DropLegendario();
        }else if(numRandom < 101)
        {
            DropReliquia();
        }
    }
    public void CofreDiamante()
    {
        int numRandom = Random.Range(1, 101);
        if (numRandom < 2)
        {
            DropBronce();
        }
        else if (numRandom < 10)
        {
            DropHierro();
        }
        else if (numRandom < 20)
        {
            DropOro();
        }
        else if (numRandom < 40)
        {
            DropPlatino();
        }
        else if (numRandom < 80)
        {
            DropLegendario();
        }
        else if(numRandom < 101)
        {
            DropReliquia();
        }
    }

    public void DropBronce()
    {
        int numRandom = Random.Range(0, bronce.Length );
        

    }
    public void DropHierro()
    {
        int numRandom = Random.Range(0, hierro.Length );
    }
    public void DropOro()
    {
        int numRandom = Random.Range(0, oro.Length);
    }
    public void DropPlatino()
    {
        int numRandom = Random.Range(0, platino.Length);
    }
    public void DropLegendario()
    {
        int numRandom = Random.Range(0, legendaria.Length);
    }
    public void DropReliquia()
    {
        int numRandom = Random.Range(0, reliquia.Length);
    }
}
