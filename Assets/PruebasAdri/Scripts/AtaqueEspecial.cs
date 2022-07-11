using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspecial : MonoBehaviour
{
    public GameObject efectos;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Efecto(int espada)
    {
        Instantiate(efectos, player.transform);
        switch (espada)
        {

        }
    }
}
