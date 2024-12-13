using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBG : MonoBehaviour
{

    private static AudioBG instance;

    void Awake()
    {
        // Comprueba la instancia
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destruye duplicados
            Destroy(gameObject); 
        }
    }
}





