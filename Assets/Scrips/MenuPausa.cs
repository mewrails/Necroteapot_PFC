using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Pausa;
    public bool pausita;
    // Start is called before the first frame update
    void Start()
    {
        Pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pausarJuego();
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void pausarJuego()
    {
        Pausa.SetActive(true);
        Time.timeScale = 0f;
        pausita = true;
    }

    public void Despausar()
    {
        Pausa.SetActive(false);
        Time.timeScale = 1f;
        pausita = false;
    }
    public void BackToMM()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menuPrincipal");
    }
    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
        //para compprobar que funciona
        //Debug.Log("Game Finished");
    }
}
