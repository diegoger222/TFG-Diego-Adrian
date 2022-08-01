using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer musica;
    public AudioMixer efectos;
    public void SetMusica (float volumen)
    {
        musica.SetFloat("musica", volumen);
    }

    public void SetEfectos(float volumen)
    {
        efectos.SetFloat("efectos", volumen);
    }

}
