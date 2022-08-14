using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspecial : MonoBehaviour
{
    public GameObject efectos;
    private GameObject player;
    private int aux;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Efecto(int espada)
    {
        aux = espada;
        GameObject efecto = efectos;
        Vector2 pos = new Vector2(player.transform.position.x, player.transform.position.y);
        switch (espada)
        {
            case 100: //Espada Ancla
                efecto.transform.GetChild(2).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 101: //Espada de Agua
                efecto.transform.GetChild(3).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 102: //Espada de Fuego
                efecto.transform.GetChild(5).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 103: //Espada de Hielo
                efecto.transform.GetChild(6).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 104: //Espada de Luz
                efecto.transform.GetChild(7).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 105: //Espada de Madera
                efecto.transform.GetChild(9).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 106: //Espada de Rayo
                efecto.transform.GetChild(12).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 107: //Espada de Roca
                efecto.transform.GetChild(14).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 108: //Espada de Tierra
                efecto.transform.GetChild(15).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 109: //Espada de Trueno
                efecto.transform.GetChild(13).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 110: //Espada de Veneno
                efecto.transform.GetChild(22).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 111: //Espada de Viento
                efecto.transform.GetChild(25).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 113: //Espada Explosiva
                efecto.transform.GetChild(4).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 114: //Espada Insecto
                efecto.transform.GetChild(23).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 116: //Espada Maldita
                efecto.transform.GetChild(10).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 117: //Espada Meteorito
                efecto.transform.GetChild(16).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 121: //Espada Oscura
                efecto.transform.GetChild(20).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 122: //Espada Pez
                efecto.transform.GetChild(1).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 124: //Espada Pluma
                efecto.transform.GetChild(24).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 125: //Espada Solar
                efecto.transform.GetChild(8).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 126: //Espada Vórtice
                efecto.transform.GetChild(0).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 128: //Espadón Galáctico
                efecto.transform.GetChild(18).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 129: //Espadón Maldito
                efecto.transform.GetChild(11).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 130: //Espadón Musical
                break;
            case 131: //Espadón Sangriento
                efecto.transform.GetChild(21).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 133: //Estoque
                efecto.transform.GetChild(17).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            case 134: //Katana
                efecto.transform.GetChild(19).gameObject.SetActive(true);
                Instantiate(efecto, pos, Quaternion.identity);
                break;
            default:
                break;
        }
        Invoke("EfectoFin", 0.1f);
    }
    public void EfectoFin()
    {
        switch (aux)
        {
            case 100: //Espada Ancla
                efectos.transform.GetChild(2).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("WaterSplash2");
                break;
            case 101: //Espada de Agua
                efectos.transform.GetChild(3).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("WaterB");
                break;
            case 102: //Espada de Fuego
                efectos.transform.GetChild(5).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Fire");
                break;
            case 103: //Espada de Hielo
                efectos.transform.GetChild(6).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Ice");
                break;
            case 104: //Espada de Luz
                efectos.transform.GetChild(7).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Light");
                break;
            case 105: //Espada de Madera
                efectos.transform.GetChild(9).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Wood");
                break;
            case 106: //Espada de Rayo
                efectos.transform.GetChild(12).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Lightning");
                break;
            case 107: //Espada de Roca
                efectos.transform.GetChild(14).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Earth");
                break;
            case 108: //Espada de Tierra
                efectos.transform.GetChild(15).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Earth");
                break;
            case 109: //Espada de Trueno
                efectos.transform.GetChild(13).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Thunder");
                break;
            case 110: //Espada de Veneno
                efectos.transform.GetChild(22).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("PoisonB");
                break;
            case 111: //Espada de Viento
                efectos.transform.GetChild(25).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Wind");
                break;
            case 113: //Espada Explosiva
                efectos.transform.GetChild(4).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Explosion");
                break;
            case 114: //Espada Insecto
                efectos.transform.GetChild(23).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Poison");
                break;
            case 116: //Espada Maldita
                efectos.transform.GetChild(10).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Soul");
                break;
            case 117: //Espada Meteorito
                efectos.transform.GetChild(16).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Earth");
                break;
            case 121: //Espada Oscura
                efectos.transform.GetChild(20).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Bat");
                break;
            case 122: //Espada Pez
                efectos.transform.GetChild(1).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("WaterSplash");
                break;
            case 124: //Espada Pluma
                efectos.transform.GetChild(24).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Feather");
                break;
            case 125: //Espada Solar
                efectos.transform.GetChild(8).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Solar");
                break;
            case 126: //Espada Vórtice
                efectos.transform.GetChild(0).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("WaterTornado");
                break;
            case 128: //Espadón Galáctico
                efectos.transform.GetChild(18).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Galaxy");
                break;
            case 129: //Espadón Maldito
                efectos.transform.GetChild(11).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Souls");
                break;
            case 130: //Espadón Musical
                int random = Random.Range(1, 4);
                    if (random == 1)
                {
                    GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Re");
                } else if (random == 2)
                {
                    GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Sol");
                } else if (random == 3)
                {
                    GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Si");
                }
                break;
            case 131: //Espadón Sangriento
                efectos.transform.GetChild(21).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Blood");
                break;
            case 133: //Estoque
                efectos.transform.GetChild(17).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Rapier");
                break;
            case 134: //Katana
                efectos.transform.GetChild(19).gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("Sonidos").GetComponent<ActivadorSonidos>().ActivarSonido("Katana");
                break;
            default:
                break;
        }
    }
}
