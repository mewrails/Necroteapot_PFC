using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitToMM : MonoBehaviour
{
    public void Back()
    {
        //Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("menuPrincipal");
    }
}
