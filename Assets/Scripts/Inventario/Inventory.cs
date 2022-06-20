using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] slots;
    public GameObject[] slotsEstadisticas;
    
    //public Dictionary<GameObject, InventorySlot> slotsEnInterfaz = new Dictionary<GameObject, InventorySlot>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private void ActualizarSlot(InventorySlot _slot)
    {
        if(_slot.item.Id >= 0)
        {
          
        }
    }
    */
    public GameObject SlotLibre()
    {

        for(int i = 0; i < slots.Length; i++)
        {
            if (slots[i].GetComponent<Slot>().item == null)
            {
                return slots[i];
            }
        }
        return null;
    }

    public GameObject SlotInventario(Item _item)
    {

        for(int i = 0; i < slots.Length; i++)
        {
            if(slots[i].GetComponent<Slot>().itemO.Id == _item.Id)
            {
                return slots[i];
            }
        }
        return null;
    }


    public bool AnyadirItem(ItemObject _itemObject) 
    {
        if (_itemObject.stackable)
        {
            GameObject slotauxStack = SlotInventario(_itemObject.data);
            if (slotauxStack)
            {
                slotauxStack.GetComponent<Slot>().AnyadirObjeto(_itemObject);
              
                return true;
            }
            else
            {
                GameObject slotAux = SlotLibre();
                if (slotAux)
                {
                    slotAux.GetComponent<Slot>().AnyadirObjeto(_itemObject);
                    Debug.Log("HOLI");
                    return true;
                }
            }
        }
        else
        {
            GameObject slotaux = SlotLibre();
            if (slotaux)
            {
                slotaux.GetComponent<Slot>().AnyadirObjeto(_itemObject);
                return true;
            }
        }
        return false;
    }


    //inventario Equipo
    public GameObject SlotLibreEstadisticas(ItemType _type)
    {

        for (int i = 0; i < slotsEstadisticas.Length; i++)
        {
            if (slotsEstadisticas[i].GetComponent<SlotEquipo>().item == null)
            {
                if(_type.ToString() == slotsEstadisticas[i].GetComponent<SlotEquipo>().type.ToString())
                {
                    return slotsEstadisticas[i];
                }
                
            }
        }
        return null;
    }

    public bool AnyadirEquipo(ItemObject _itemObject)
    {
        GameObject slotEq = SlotLibreEstadisticas(_itemObject.type);
        if (slotEq)
        {
            slotEq.GetComponent<SlotEquipo>().AnyadirObjeto(_itemObject);
            return true;
        }
        return false;
    }
}


