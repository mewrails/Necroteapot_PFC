using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    [Header("Raycast Features")]
    [SerializeField] private float rayLength = 5;
    private Camera _camera;

    private NoteController NoteController;

    [Header("crosshair")]
    [SerializeField] private Image xhair;

    [Header("Input Key")]
    [SerializeField] private KeyCode interactKey;

    void Start()
    {
        _camera = GetComponent<Camera>();

    }

    void Update()
    {
        //linea to larga para centrar la camara y el raycast
        if (Physics.Raycast(_camera.ViewportToWorldPoint(new Vector3 (0.5f , 0.5f)), transform.forward, out RaycastHit hit, rayLength))
        {
            var readableItem = hit.collider.GetComponent<NoteController>();

            if (readableItem != null)
            {
                NoteController = readableItem;
                HighlightXhair(true);
            }
            else
            {
                ClearNote();
            }
        }
        else
        {
            ClearNote();
        }

        if (NoteController != null)
        {
            if (Input.GetKeyDown (interactKey))
            {
                NoteController.ShowNote();
            }
        }
    }

    void ClearNote()
    {
        if (NoteController != null)
        {
            HighlightXhair(false);
            NoteController = null;
        }
    }

    void HighlightXhair (bool on)
    {
        if (on)
        {
            xhair.color = Color.yellow;
        }
        else
        {
            xhair.color = Color.white;
        }

    }
}
