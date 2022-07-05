using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCaw : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public bool dere = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dere)
        {
            transform.position += Vector3.up * velocidad *0.2f* Time.deltaTime;
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.up * velocidad * 0.2f * Time.deltaTime;
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        
    }
}
