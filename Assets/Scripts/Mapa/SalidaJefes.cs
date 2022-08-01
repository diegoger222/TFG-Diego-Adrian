using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalidaJefes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject salida;

    public void Start()
    {
        
    }
    public void ActivarSalida()
    {
        salida.SetActive(true);
    }
    public void DesacticarSalida()
    {
        salida.SetActive(false);
    }
}
