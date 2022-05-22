using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    // Start is called before the first frame update



    //Stamina
    public Image staminaBar;

    private int maxStamina = 100;
    private float currentStamina = 80;

    private WaitForSeconds regenTick = new WaitForSeconds(0.025f);
    private Coroutine regen;

    public static Stamina instance;
    //public PlayerController player;


    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentStamina = maxStamina;
    
    }

    // Update is called once per frame
    void Update()
    {
       staminaBar.fillAmount = currentStamina / maxStamina;

    }

    public void RestarEstamina(int cantidad)
    {
        currentStamina -= cantidad;
        
    }

    public float ReturnStamina()
    {
        return currentStamina;
    }

    public void UsarStamina(float cantidad)
    {
        if(currentStamina- cantidad >= 0)
        {
            currentStamina -= cantidad;

            if(regen != null) {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenStamina());
        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(1.5f);

        while(currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 100;
            yield return regenTick;
        }
    }

    public void SumarPuntosStamina(int puntos)
    {
        maxStamina += puntos;
    }
    public void RestarPuntosStamina(int puntos)
    {
        maxStamina -= puntos;
    }

    /*
    public void ResetMaxStamina() 
    {
        maxStamina = 100;
    }
    */


}
