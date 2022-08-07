using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ItemType
{ 
    Comida,
    Pocion,
    Arma,
    Casco,
    Pechera,
    Pantalones,
    Zapatos,
    Anillo,
    Collar,
    Escudo,
    Patata,
    Gema

}

public enum Atributos
{
    Fuerza,
    Inteligencia,
    DefensaFisica,
    DefensaMagica,
    Suerte,
    Mana,
    Vida
}
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory System/Items/item")]

public class ItemObject : ScriptableObject
{

    public Sprite uiDisplay;
    public bool stackable;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
    public Item data = new Item();

    public Item CreateItem()
    {
        Item newItem = new Item(this);
        return newItem;
    }
   
    public ItemObject getCopyItemObject()
    {
        ItemObject copy = new ItemObject();
        copy.uiDisplay = this.uiDisplay;
        copy.stackable = this.stackable;
        copy.type = this.type;
        copy.description = this.description;
        copy.data.Name = this.data.Name;
        copy.data.Id = this.data.Id;
        copy.data.buffs = new ItemBuff[this.data.buffs.Length];
        for (int i = 0; i < copy.data.buffs.Length; i++)
        {
            copy.data.buffs[i] = new ItemBuff(this.data.buffs[i].min, this.data.buffs[i].max)
            {
                attribute = this.data.buffs[i].attribute
            };
        }
        return copy;
    }

}

[System.Serializable]
public class Item
{
    public string Name;
    public int Id = -1;
    public ItemBuff[] buffs;
    public Item()
    {
        Name = "";
        Id = -1;
    }
    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.data.Id;
        buffs = new ItemBuff[item.data.buffs.Length];
        for (int i = 0; i < buffs.Length; i++)
        {
            buffs[i] = new ItemBuff(item.data.buffs[i].min, item.data.buffs[i].max)
            {
                attribute = item.data.buffs[i].attribute
            };
        }
    }
}


[System.Serializable]

public class ItemBuff : IModifier
{
    public Atributos attribute;
    public int value;
    public int min;
    public int max;
    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max = _max;
        GenerateValue();
    }

    public void AddValue(ref int baseValue)
    {
        baseValue += value;
    }

    public void GenerateValue()
    {
        value = UnityEngine.Random.Range(min, max);
    }
}

