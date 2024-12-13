using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [Header("Configuración del Ratón")]
    [SerializeField] private float sensibilidadMouse = 100f;
    [SerializeField] private Transform jugadorBody;

    private float rotacionX = 0f;
    private Controles misControles;

    void Awake()
    {
        if (jugadorBody == null)
        {
            Debug.LogError("Jugador Body (Player) Transform is not assigned.");
        }
    }

    private void OnEnable()
    {
        misControles = new Controles();
        misControles.gamplay.MouseMovement.performed += OnMouseMoved;

        misControles.gamplay.MouseMovement.performed += OnMouseMoved;

        // Bloquear el cursor cuando se habilita
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnDisable()
    {
        misControles.gamplay.MouseMovement.performed -= OnMouseMoved;
        misControles.gamplay.Disable();

        // Desbloquear el cursor cuando se deshabilita
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnMouseMoved(InputAction.CallbackContext context)
    {
        Vector2 mouseDelta = context.ReadValue<Vector2>();

        float mouseX = mouseDelta.x * sensibilidadMouse * Time.deltaTime;
        float mouseY = mouseDelta.y * sensibilidadMouse * Time.deltaTime;

        // Rotar el cuerpo del jugador horizontalmente
        jugadorBody.Rotate(Vector3.up * mouseX);

        // Rotar la camara verticalmente
        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
    }
}
