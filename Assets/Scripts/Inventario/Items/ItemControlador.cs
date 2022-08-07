using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControlador : MonoBehaviour
{
    public ItemObject item;

    public void Start()
    {
        if (!item.stackable)
        {
            item.data = item.CreateItem();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ItemObject anyadirItem = item.getCopyItemObject();

            bool patata = GameObject.FindGameObjectWithTag("Inventario").GetComponent<Inventory>().AnyadirItem(anyadirItem);
            //Patata 
            if (patata)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
