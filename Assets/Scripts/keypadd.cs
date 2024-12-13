using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypadd : MonoBehaviour
{
    public GameObject jugador;

    public GameObject KeypadPHYS;

    public GameObject hud;

    public GameObject doorPad;

    public Text codeText;

    public string answer = "413612";

    void Start()
    {
        KeypadPHYS.SetActive(false);
    }

   
    
    public void number(int number)
    {
        codeText.text += number.ToString();

    }

    public void execute()
    {
        if(codeText.text == answer)
        {
            codeText.text = "correct";
        }
        else
        {
            codeText.text = "try again";
        }
    }

    public void clear()
    {
        codeText.text = "";
    }

    public void exit()
    {
        KeypadPHYS.SetActive(false);
        hud.SetActive(true);
    }

    void Update()
    {
        if (codeText.text == "correct")
        {
            // Debug.Log("open");
            doorPad.SetActive(false);
            Destroy(gameObject);
        }
        if (KeypadPHYS.activeInHierarchy)
        {
            KeypadPHYS.SetActive(true);
            hud.SetActive(false);
        }
    }
}
