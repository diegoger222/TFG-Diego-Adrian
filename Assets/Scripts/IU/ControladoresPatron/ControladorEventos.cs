using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEventos : MonoBehaviour
{
    // Start is called before the first frame update
    public static ControladorEventos Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ControladorEventos.Instance == null)
        {
            ControladorEventos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
