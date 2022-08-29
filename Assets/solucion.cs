using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solucion : MonoBehaviour
{

    public GameObject IU;
    // Start is called before the first frame update
    void Start()
    {
        IU.SetActive(true);

        Invoke("Cerrar", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cerrar()
    {
        IU.SetActive(false);
    }
}
