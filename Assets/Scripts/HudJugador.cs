using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudJugador : MonoBehaviour
{
    //salud morgan
    public float vida;
    public float MaxVida;
    public Image barraVida;

    public string endScene;

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

       if (vida <= 0)
        {
            SceneManager.LoadScene("loseCreds");
        }
    }

    public HudJugador SaludJugador;
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        //recibe daño
        if (other.GetComponent<HudJugador>())
        {
            SaludJugador.vida -= damage;
        }
    }


}
