using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WinLose : MonoBehaviour
{
    private bool gameOver = false;
    //funcion para ganar el juego
    public void GanarNivel()
    {
        //testear condicion ganar juego
        //Debug.Log("WINNER");

    }

    //funcion para perder el juego
    public void PerderNivel()
    {

        if (!gameOver)
        {
            //testear perder
            //Debug.Log("LOSER");
            gameOver = true;
        }
    }
}

