using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaPinchoMovil : MonoBehaviour
{

    private Vector3 puntoInicial;
    public float distancia;
    private Vector3 puntoFinal;
    private SpriteRenderer spriteRenderer;
    private Vector3 target;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        puntoFinal = new Vector3(puntoInicial.x + distancia, puntoInicial.y, puntoInicial.z);
        target = puntoFinal;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    public void Mover()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, velocidad * Time.deltaTime);
        if (transform.position.x == target.x)
        {
            spriteRenderer.flipX = true;
            if(target.x == puntoFinal.x)
            {
                target = puntoInicial;
            }
            else if(target.x == puntoInicial.x)
            {
                target = puntoFinal;
            }
        }
    }
}
