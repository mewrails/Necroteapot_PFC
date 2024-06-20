using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public HudJugador SaludJugador;
    public float damage;
    public GameObject uiTxt;

    private void Start()
    {
        uiTxt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HudJugador>())
        {
            SaludJugador.vida -= damage;
            uiTxt.SetActive(true);
            StartCoroutine("WaitTime");
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1);
        uiTxt.SetActive(false);
    }

}
