using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    //puerta coms
    public GameObject puertaCollider;
    public GameObject llaveCollider;
    public GameObject uiDoorTxt;

    // Start is called before the first frame update
    void Start()
    {
        uiDoorTxt.SetActive(false);
        //puerta cerrada cuando empieza el juego
        puertaCollider.SetActive(true);
        llaveCollider.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        //abrir puerta
        if (other.gameObject.tag == "Player")
        {
            //destruye llave y abre puerta
            puertaCollider.SetActive(false);
            llaveCollider.SetActive(false);
            Destroy(gameObject);
            

            uiDoorTxt.SetActive(true);
            StartCoroutine("WaitTime");
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1);
        uiDoorTxt.SetActive(false);
    }
}
