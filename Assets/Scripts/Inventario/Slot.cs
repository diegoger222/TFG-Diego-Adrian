using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Slot : MonoBehaviour, IPointerClickHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    // public Item item = new Item();
    public ItemObject item;
    public Item itemO = new Item();
    public int cantidad = 0;
    private bool informacion = false;
    
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

        //item.data.Id >=0
        if (item !=null) 
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

                if(item.type.ToString() == "Arma" || item.type.ToString() == "Casco" || item.type.ToString() == "Pechera" || item.type.ToString() == "Pantalones" || item.type.ToString() == "Zapatos" || item.type.ToString() == "Anillo" || item.type.ToString() == "Collar" || item.type.ToString() == "Escudo" || item.type.ToString() == "Patata")
                {
                   bool a =  GameObject.FindGameObjectWithTag("Inventario").GetComponent<Inventory>().AnyadirEquipo(item);
                    if (a)
                    {
                        EliminarObjeto();
                    }
                }
                else
                {
                    UsarItem();
                }
                
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
               // if(item.type.ToString() == "Arma")
                //{
                    informacion = true;
                    GameObject.FindGameObjectWithTag("InformacionE").transform.position = new Vector2(this.transform.position.x + 300, 600);
                    GameObject.FindGameObjectWithTag("InformacionE").GetComponent<InformacionInvetario>().ActualizarInformacion(item);
               // }
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
            case 11:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(10);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(10);
                }
                break;
            case 12:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(20);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(20);
                }
                break;
            case 13:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(30);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(30);
                }
                break;
            case 14:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(40);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(40);
                }
                break;
            case 15:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(50);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<BarraDeVida>().sumarVidaPoti(50);
                }
                break;
            case 16:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(10);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(10);
                }
                break;
            case 17:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(20);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(20);
                }
                break;
            case 18:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(30);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(30);
                }
                break;
            case 19:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(40);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(40);
                }
                break;
            case 20:
                if ((cantidad - 1) <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(50);
                    EliminarObjeto();
                }
                else
                {
                    cantidad--;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Mana>().SumarPoti(50);
                }
                break;
            default:
                break;
        }
    
    }
    

}
