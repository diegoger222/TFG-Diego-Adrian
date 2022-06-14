using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Slot : MonoBehaviour
{
    // Start is called before the first frame update
    // public Item item = new Item();
    public ItemObject item;
    public Item itemO = new Item();
    public int cantidad = 0;
   
    
    public void Start()
    {
        // ImagenSlot = this.transform.GetChild(0);
        ActualizarImagen();
    }
    private void Update()
    {
        ActualizarImagen();
    }

    public void ActualizarImagen()
    {

        if(item != null)
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = item.uiDisplay;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = cantidad == 1 ? "" : cantidad.ToString("n0");
        }
        else
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = null;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
            this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "";
        }
        
    }

    public void AnyadirObjeto(ItemObject _item)
    {
        if (item.data.Id >=0) 
        {
            cantidad++;
        }
        else
        {
            item = _item;
            itemO = _item.data;
            cantidad = 1;
        }
    }

    public void EliminarObjeto()
    {
        item = null;
        itemO = new Item();
        cantidad = 0;
    }
    
    public void CambiarObjeto(ItemObject _item,int _cantidad)
    {
        item = _item;
        itemO = _item.data;
        cantidad = _cantidad;
    }



    //Eventos 
    public void OnPointerClick()
    {
        if (item != null)
        {
           
                if (item.data.Id ==1)
                {
                    Debug.Log("POPOOO");
                }

            
        }

    }


    //prueba

    protected void AddEvent(EventTriggerType type, UnityAction<BaseEventData> action)
    {
        EventTrigger trigger = this.GetComponent<EventTrigger>();
        var eventTrigger = new EventTrigger.Entry();
        eventTrigger.eventID = type;
        eventTrigger.callback.AddListener(action);
        trigger.triggers.Add(eventTrigger);
    }

    

}
