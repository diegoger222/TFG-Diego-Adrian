using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprobador : MonoBehaviour
{
    public string comprobarVariable;
    public GameObject[] eliminar;
    // Start is called before the first frame update
    void Start()
    {
        if(comprobarVariable != null)
        {
            Ejecutar(comprobarVariable);
        }
    }

    private void Update()
    {
        if (comprobarVariable != null)
        {
            Ejecutar(comprobarVariable);
        }
    }

    private void Ejecutar(string comprobarVariable)
    {
        bool variable = FindObjectOfType<ComprobadorMision>().GetVariable(comprobarVariable);
        if (variable)
        {
            foreach(GameObject gameObject in eliminar)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
