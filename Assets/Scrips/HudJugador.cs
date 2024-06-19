using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudJugador : MonoBehaviour
{
    //salud morgan
    public float vida;
    public float MaxVida;
    public Image barraVida;

    // Start is called before the first frame update
    void Start()
    {
        //vida al maximo al empezar
        MaxVida = vida;
    }

    // Update is called once per frame
    void Update()
    {
        //barra de vida llena + cambios

        barraVida.fillAmount = Mathf.Clamp(vida / MaxVida, 0, 1);

    }

    public HudJugador SaludJugador;
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HudJugador>())
        {
            SaludJugador.vida -= damage * Time.deltaTime;
        }
    }


}
