using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlIUPortales : MonoBehaviour
{

    public GameObject iuPortal;
    private bool interactuar = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactuar && Input.GetKeyDown("f"))
        {
            iuPortal.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            iuPortal.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactuar = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactuar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactuar = false;
    }
}
