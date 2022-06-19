using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformacionInvetario : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite fuerza;
    public Sprite inteligencia;
    public Sprite defensaFisica;
    public Sprite defensaMagica;
    public Sprite suerte;
    public Sprite mana;
    public Sprite vida;
    //donde van las estadisticas del item
    public GameObject[] estadisticas;
    public GameObject imagen;
    public GameObject textos;
    public GameObject interfazInf;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActualizarInformacion(ItemObject _item)
    {
        interfazInf.SetActive(true);

        for(int i = 0; i <= 2; i++)
        {
           if(i< _item.data.buffs.Length)
            {
                ActualizarEstadisticas(estadisticas[i], _item.data.buffs[i]);
            }
            else
            {
                ActualizarEstadisticas(estadisticas[i], null);
            }
          
        }
        imagen.GetComponent<Image>().sprite = _item.uiDisplay;
        textos.transform.GetChild(0).GetComponent<Text>().text = _item.name;
        textos.transform.GetChild(1).GetComponent<Text>().text = _item.description;

    }

    public void ActualizarEstadisticas(GameObject _gameObject,ItemBuff _buff) 
    {
        if(_buff == null)
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = null;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
        }
        else if(_buff.attribute.ToString() == "Fuerza")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = fuerza;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "Inteligencia")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = inteligencia;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "DefensaMagica")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = defensaMagica;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "DefensaFisica")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = defensaFisica;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "Suerte")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = suerte;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "Mana")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = mana;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else if (_buff.attribute.ToString() == "Vida")
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = vida;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = _buff.value.ToString();
        }
        else
        {
            _gameObject.transform.GetChild(0).GetComponent<Image>().sprite = null;
            _gameObject.transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
            _gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
        }

    }

    public void Desactivar()
    {
        interfazInf.SetActive(false);
    }
/*
    Fuerza,
    Inteligencia,
    DefensaFisica,
    DefensaMagica,
    Suerte,
    Mana,
    Vida
*/
}
