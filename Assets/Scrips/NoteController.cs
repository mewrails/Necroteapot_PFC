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
        
    }

    public void ShowNote()
    {
        //noteTextAreaUI.text = MoveNote
    }
}
