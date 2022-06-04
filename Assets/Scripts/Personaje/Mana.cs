using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mana : MonoBehaviour
{
    // Start is called before the first frame update
    public Image manaBar;

    private float maxMana = 100;
    private float currentMana = 80;

    private WaitForSeconds regenTick = new WaitForSeconds(0.025f);
    private Coroutine regen;

    public static Mana instance;
    //public PlayerController player;


    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentMana = maxMana;

    }

    // Update is called once per frame
    void Update()
    {
        manaBar.fillAmount = currentMana / maxMana;

    }

    public void RestarMana(int cantidad)
    {
        currentMana -= cantidad;

    }

    public float ReturnMana()
    {
        return currentMana;
    }

    public void UsarMana(float cantidad)
    {
        if (currentMana - cantidad >= 0)
        {
            currentMana -= cantidad;

            if (regen != null)
            {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenMana());
        }
    }

    private IEnumerator RegenMana()
    {
        yield return new WaitForSeconds(1.5f);

        while (currentMana < maxMana)
        {
            currentMana += maxMana / 100;
            yield return regenTick;
        }
    }

    public void SumarPuntosMana(int puntos)
    {
        maxMana += puntos;
    }
    public void RestarPuntosMana(int puntos)
    {
        maxMana -= puntos;
    }

}
