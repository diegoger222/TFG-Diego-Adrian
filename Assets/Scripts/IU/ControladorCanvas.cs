using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCanvas : MonoBehaviour
{
    public static ControladorCanvas Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ControladorCanvas.Instance == null)
        {
            ControladorCanvas.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
