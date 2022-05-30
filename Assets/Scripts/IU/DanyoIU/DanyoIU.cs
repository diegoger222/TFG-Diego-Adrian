using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DanyoIU : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject texto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarDanyo(float danyo) {
        GameObject textOb = Instantiate(texto, transform.position +Random.onUnitSphere, Quaternion.identity);
        textOb.GetComponent<TextMeshPro>().SetText(danyo.ToString());

        //StartCoroutine(MoverTexto(textOb));
    
    }

    IEnumerator MoverTexto(GameObject ob)
    {
        Vector2 inicial = new Vector2(ob.transform.position.x, ob.transform.position.y);
        Vector2 final = new Vector2(ob.transform.position.x, ob.transform.position.y +10);
        int tiempo = 0;
        while (tiempo < 100)
        {
            tiempo++;
            ob.transform.position = Vector2.MoveTowards(inicial, final, 15f * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
      Destroy(ob);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Arma"))
        {
            MostrarDanyo(20);
        }
    }
    
}
