using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SlotEquipo : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    // public Item item = new Item();
    public ItemObject item;
    public Item itemO = new Item();
    public int cantidad = 0;
    private bool informacion = false;
    public ItemType type;
    public enum ItemType
    {
        Arma,
        Casco,
        Pechera,
        Pantalones,
        Zapatos,
        Anillo,
        Collar,
        Escudo,
        Patata
    }

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

        if (item != null)
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = item.uiDisplay;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            this.transform.GetComponent<Image>().color = new Color(1, 1, 1, 0);
            this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = cantidad == 1 ? "" : cantidad.ToString("n0");
        }
        else
        {
            this.transform.GetChild(0).GetComponent<Image>().sprite = null;
            this.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
            this.transform.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "";
        }

    }

    public void AnyadirObjeto(ItemObject _item)
    {

        //item.data.Id >=0
        if (item != null)
        {
            cantidad++;
        }
        else
        {

            item = _item;
            itemO = _item.data;
            cantidad = 1;
            SumarEstadisticas(item);
        }
    }

    public void EliminarObjeto()
    {
        RestarEstadisticas(item);
        item = null;
        itemO = new Item();
        cantidad = 0;
    }

    public void CambiarObjeto(ItemObject _item, int _cantidad)
    {
        item = _item;
        itemO = _item.data;
        cantidad = _cantidad;
    }



    //Eventos 
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Hola");
        if (informacion)
        {
            GameObject.FindGameObjectWithTag("InformacionE").GetComponent<InformacionInvetario>().Desactivar();
            informacion = false;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {


        if (item != null)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {

               
                    bool a = GameObject.FindGameObjectWithTag("Inventario").GetComponent<Inventory>().AnyadirItem(item);
                    if (a)
                    {
                        EliminarObjeto();
                    }
                
                //UsarItem();
                /*
                if (item.data.Id == 1)
                {
                    Debug.Log("POPOOO");
                }
                */
            }

            if (eventData.button == PointerEventData.InputButton.Right)
            {
                /*
                if (item.data.Id == 1)
                {
                    Debug.Log("hehee");
                }
                */
                  informacion = true;
                    GameObject.FindGameObjectWithTag("InformacionE").transform.position = new Vector2(this.transform.position.x + 300, 600);
                    GameObject.FindGameObjectWithTag("InformacionE").GetComponent<InformacionInvetario>().ActualizarInformacion(item);
                
            }



        }

    }

    private void SumarEstadisticas(ItemObject _item)
    {
        for (int i = 0; i <= 2; i++)
        {
            if (i < _item.data.buffs.Length)
            {

                GameObject.FindGameObjectWithTag("Player").GetComponent<Estadisticas>().SumarEstadisticas(_item.data.buffs[i]);
               // ActualizarEstadisticas(estadisticas[i], _item.data.buffs[i]);
            }
            else
            {
                //ActualizarEstadisticas(estadisticas[i], null);
            }

        }
    }

    private void RestarEstadisticas(ItemObject _item)
    {
        for (int i = 0; i <= 2; i++)
        {
            if (i < _item.data.buffs.Length)
            {

                GameObject.FindGameObjectWithTag("Player").GetComponent<Estadisticas>().RestarEstadisticas(_item.data.buffs[i]);
                // ActualizarEstadisticas(estadisticas[i], _item.data.buffs[i]);
            }
            else
            {
                //ActualizarEstadisticas(estadisticas[i], null);
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


    public void UsarItem()
    {
        switch (item.data.Id)
        {
            case 1:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().RestarVida(-30);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().RestarVida(-30);
                }
                break;
            case 2:
                break;
            default:
                break;
        }

    }
}
