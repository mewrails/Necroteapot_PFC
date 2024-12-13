using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;


public class NoteController : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] private KeyCode closeKey;

    [Space(10)]
    [SerializeField] private CharacterController jugador;

    [Header("UI Text")]
    [SerializeField] private GameObject NotaBG;
    [SerializeField] private TMP_Text MoveNoteTXT;

    [Space(10)]
    [SerializeField] [TextArea] private string MoveNote;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (isOpen)
        {
            if((Input.GetKeyDown(closeKey)))
            {
                DisableNote();
            }
        }
    }

    public void ShowNote()
    {
        MoveNoteTXT.text = MoveNote;
        NotaBG.SetActive(true);
        openEvent.Invoke();
        DisablePlayer(true);
        isOpen = true;
    }
    public void DisableNote()
    {
        NotaBG.SetActive(false);
        DisablePlayer(false);
        isOpen = false;
    }

   /* void DisablePlayer (bool disable)
    {
        jugador.enabled = !disable;
    }*/
    void DisablePlayer(bool disable)
    {
        if (jugador == null)
        {
            Debug.LogError("Jugador no esta asignado! Asignalo a el NoteController en el Inspector");
            return;
        }

        Debug.Log($"Disabling Player: {disable}");
        jugador.enabled = !disable;
    }
}
