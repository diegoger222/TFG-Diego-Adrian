using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    // Start is called before the first frame update
    // public Item item = new Item();
    public ItemObject item;
    public Item itemO = new Item();
    public int cantidad;
   
    
    public void Start()
    {
        // ImagenSlot = this.transform.GetChild(0);
        ActualizarImagen();
    }

    public void ActualizarImagen()
    {

        if(item != null)
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = item.uiDisplay;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        else
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = null;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        
    }

    public void AnyadirObjeto(ItemObject _item)
    {
        if (itemO.Id >=0) 
        {
            cantidad++;
        }
    }

    public void EliminarObjeto()
    {
        item = null;
        itemO = new Item();
        cantidad = 0;
    }
}
