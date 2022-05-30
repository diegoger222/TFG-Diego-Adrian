using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoIU : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad;
    public float tiempo;
    void Start()
    {
        Destroy(gameObject, tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * velocidad *Time.deltaTime;
    }
}
