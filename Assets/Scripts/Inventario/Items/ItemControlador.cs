using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControlador : MonoBehaviour
{
    public ItemObject item;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("PATATA");
            GameObject.FindGameObjectWithTag("Inventario").GetComponent<Inventory>().AnyadirItem(item);
            Debug.Log("PATATA");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("PATATA");
            bool patata = GameObject.FindGameObjectWithTag("Inventario").GetComponent<Inventory>().AnyadirItem(item);
            Debug.Log(patata);
        }
    }
}
