using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Experiencia : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text_nivel;
    public Text text_exp;
    public Image barra_exp;
    public Text textoValorBarraExperiencia;
    //public Image pot_exp;
    private float act_nivel;
    private float exp_nivel; // lo que te cuesta subir de nivel base
    private int var_nivel; // experiencia extra que cuesta por cada nivel 
    private float exp_guar; // experiencia guardada
    private float exp_acumul; //experiencia acomulada
    private int puntos_skills;
    private float exp_perdi; //experiencia perdida al morir
    private GameObject skillpoints;

    private float experienciaNecesaria;
    void Start()
    {
        act_nivel = 1;
        exp_nivel = 125; 
        var_nivel = 35;
        exp_guar = 0;
        exp_acumul = 0;
        puntos_skills = 0; 
        experienciaNecesaria = 125;
        textoValorBarraExperiencia.text = "" + exp_acumul.ToString() + " / " + experienciaNecesaria.ToString() + " XP";
    }

    // Update is called once per frame
    void Update()
    {
        text_exp.text = exp_acumul.ToString();
        text_nivel.text = act_nivel.ToString();

        barra_exp.fillAmount = exp_acumul / experienciaNecesaria;
        skillpoints = GameObject.FindGameObjectWithTag("Statsm");
    }

    public void ExperienciaPermanente()
    {
       
        exp_guar = exp_acumul;
        
        experienciaNecesaria = exp_nivel + var_nivel * (act_nivel - 1); //experiencia de nivel necesaria;
        while(exp_guar> experienciaNecesaria)
        {
           float aux_exp = exp_guar - experienciaNecesaria;
            act_nivel += 1; //subir nivel
            puntos_skills += 1; // un punto mas 
            skillpoints.GetComponent<PuntosEstadisticas>().SubirPuntos();
            skillpoints.GetComponent<PuntosEstadisticas>().Nivel(act_nivel);

            exp_acumul = aux_exp;
            experienciaNecesaria = exp_nivel + var_nivel * (act_nivel - 1);
            exp_guar = exp_acumul;
           

        }
        barra_exp.fillAmount = exp_acumul / experienciaNecesaria;
        textoValorBarraExperiencia.text = "" + exp_acumul.ToString() + " / " + experienciaNecesaria.ToString() + " XP";
    }
    
    public void GanarExperiencia(int cantidad)
    {
        exp_acumul += cantidad;
        //actualizamos la barra de experiencia y el texto con la cantidad de dicha
        barra_exp.fillAmount = exp_acumul / experienciaNecesaria;
        textoValorBarraExperiencia.text = "" + exp_acumul.ToString() + " / " + experienciaNecesaria.ToString() + " XP";
        
    }
    
    //futuro codigo que genere las potis de exp cuando mueres
    public void GenerarPotiExp()
    { 
        
    }

    public int GetPuntos()
    {
        return puntos_skills;
    }
    public void UsarPuntos()
    {
        puntos_skills--;
    }
}
