using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palanca : MonoBehaviour
{
    private bool aux = true;
    public GameObject Elevador;
    public GameObject Pala;
    // Start is called before the first frame update
    void Start()
    {
        //Pala.transform.rotation = Quaternion.Euler(0, -180, 0);
       // Pala.transform.position = new Vector3(0.548f, -2.019f, 0.56f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag== "Arma")
        {
            Elevador.GetComponent<Elevador>().Palanca();
            if (aux) {
                //Pala.transform.rotation = Quaternion.Euler(0, -180, -42.012f);
                aux = false;
            }
            else
            {
              // Pala.transform.rotation = Quaternion.Euler(0, 0, -42.012f);
                aux = true;
            }
        }
    }

}
