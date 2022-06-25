using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInventario : MonoBehaviour
{
    // Start is called before the first frame update
    public static ControladorInventario Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ControladorInventario.Instance == null)
        {
            ControladorInventario.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
