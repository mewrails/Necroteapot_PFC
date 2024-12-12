using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    [Header("Raycast Features")]
    [SerializeField] private float rayLength = 10;
    private Camera _camera;

    private NoteController NoteController;

    [Header("crosshair")]
    [SerializeField] private Image xhair;

    [Header("Input Key")]
    [SerializeField] private KeyCode interactKey;

    void Start()
    {
        _camera = GetComponent<Camera>();

        if (_camera == null)
        {
            _camera = Camera.main;
        }

        
        
    }

    void Update()
    {
        Ray ray = _camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        //linea to larga para centrar la camara y el raycast
        if (Physics.Raycast(ray, out RaycastHit hit, rayLength))
        {
            var readableItem = hit.collider.GetComponent<NoteController>();

            Debug.DrawRay(transform.position, transform.forward, Color.red);

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
            xhair.color = Color.white;
        }
        else
        {
            xhair.color = Color.yellow;
        }

    }
}
