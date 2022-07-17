using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    // Start is called before the first frame update
    public static ControladorSonido Instance;


    private void Awake()
    {
        if (ControladorSonido.Instance == null)
        {
            ControladorSonido.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
