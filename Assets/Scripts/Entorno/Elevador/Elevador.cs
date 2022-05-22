using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{


    public GameObject ObjetoAmover;

    public Transform StartPoint;
    public Transform EndPoint;

    public float Velocidad;

    private bool subir = true;

    private Vector3 MoverHacia;
    // Start is called before the first frame update
    void Start()
    {
        MoverHacia = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, Velocidad * Time.deltaTime);

        if(subir)  //ObjetoAmover.transform.position == EndPoint.position
        {
            MoverHacia = StartPoint.position;
        }

        if(!subir) //ObjetoAmover.transform.position == StartPoint.position
        {
            MoverHacia = EndPoint.position;
        }
    }


    public void Palanca()
    {
        if (subir)
        {
            subir = false;
        }
        else
        {
            subir = true;
        }
    }
}
