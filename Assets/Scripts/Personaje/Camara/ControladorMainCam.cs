using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMainCam : MonoBehaviour
{
    public static ControladorMainCam Instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (ControladorMainCam.Instance == null)
        {
            ControladorMainCam.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
