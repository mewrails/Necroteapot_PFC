using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    //puerta coms
    public GameObject puertaCollider;

    // Start is called before the first frame update
    void Start()
    {
        //puerta cerrada cuando empieza el juego
        puertaCollider.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        //abrir puerta
        if (other.gameObject.tag == "Player")
        {
            //destruye llave y abre puerta
            puertaCollider.SetActive(false);
            Destroy(gameObject);
        }
    }
}
