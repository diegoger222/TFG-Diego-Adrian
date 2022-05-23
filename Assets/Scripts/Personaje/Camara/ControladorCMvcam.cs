using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCMvcam : MonoBehaviour
{

    public static ControladorCMvcam Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ControladorCMvcam.Instance == null)
        {
            ControladorCMvcam.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
