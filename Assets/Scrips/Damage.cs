using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public HudJugador SaludJugador;
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HudJugador>())
        {
            SaludJugador.vida -= damage;
        }
    }


}
