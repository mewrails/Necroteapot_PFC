using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //boton de inicio
    public void Play()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("escena_juego");
    }

    //boton creditos

    public void Creds()
    {
        SceneManager.LoadScene("creds");
    }

    //cerrar el juego
    public void Done()
    {
        Application.Quit();
        //para compprobar que funciona
        Debug.Log("Game Finished");
    }
}
