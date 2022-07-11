using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocarEfecto : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        this.transform.rotation = player.transform.rotation;
    }
}
