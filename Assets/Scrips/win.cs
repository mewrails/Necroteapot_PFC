using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class win : MonoBehaviour
{
    //condición para ganar partida
    public WinLose WinLoseScript;
    private void OnTriggerEnter(Collider other)
    {
        WinLoseScript.GanarNivel();
        SceneManager.LoadScene("winCreds");

    }
}
