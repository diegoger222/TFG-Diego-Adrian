using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DanyoVisible : MonoBehaviour
{
    public GameObject texto;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MostrarDanyo(float danyo)
    {
        GameObject textOb = Instantiate(texto, transform.position + Random.onUnitSphere, Quaternion.identity);
        textOb.GetComponent<TextMeshPro>().fontSize = 7;
        textOb.GetComponent<TextMeshPro>().SetText(danyo.ToString());

        //StartCoroutine(MoverTexto(textOb));

    }
    public void BlockDa()
    {
        GameObject textOb = Instantiate(texto, transform.position + Random.onUnitSphere, Quaternion.identity);
        textOb.GetComponent<TextMeshPro>().fontSize = 2;
        textOb.GetComponent<TextMeshPro>().SetText("BLOCK");

        //StartCoroutine(MoverTexto(textOb));

    }

    IEnumerator MoverTexto(GameObject ob)
    {
        Vector2 inicial = new Vector2(ob.transform.position.x, ob.transform.position.y);
        Vector2 final = new Vector2(ob.transform.position.x, ob.transform.position.y + 10);
        int tiempo = 0;
        while (tiempo < 100)
        {
            tiempo++;
            ob.transform.position = Vector2.MoveTowards(inicial, final, 15f * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        Destroy(ob);
    }


    
}
