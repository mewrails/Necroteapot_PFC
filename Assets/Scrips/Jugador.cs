using UnityEngine;
using UnityEngine.InputSystem; //iclusion del nuevo sistema de inputs

public class Jugador : MonoBehaviour
{
    // Estado fisico

    [SerializeField] private int vida, cordura;

    //////////////////////////////////////////////
    // Movimiento

    [SerializeField] private float velocidadAndar, velocidadCorrer;
    private float velocidadMovimiento;
    private float velocidadRotacion;
    [SerializeField] private float velocidadAndarRotacion, velocidadCorrerRotacion;
    [SerializeField, Tooltip("Tocar este numerito, suaviza la rotación")] private float suavidadRotacion;
    private Vector3 movimientoVertical;
    CharacterController controller;
    private Controles misControles;
    Rigidbody rb;
    bool corriendo;

    //////////////////////////////////////////////
    // Gravedad

    [SerializeField] private float factorGravedad,radioDeteccion;
    [SerializeField] private LayerMask queSuelo;
    [SerializeField] private Transform pies;

    //////////////////////////////////////////////
    // Camara

    [SerializeField] private GameObject camaraNormal, camaraZoom;
    Transform cam;



    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        cam = Camera.main.transform;

        velocidadMovimiento = velocidadAndar;
        velocidadRotacion = velocidadAndarRotacion;
    }

    // SE ejecuta automaticamente antes de start cada vez
    //se activa elm objeto
    private void OnEnable()
    {
        //doy valor a la variable para que no se quede null
        misControles = new Controles();

        // esto es para ahabilitar los controles
        misControles.gamplay.Enable();

        // movimiento
        misControles.gamplay.Movimiento.performed += MoverseStarted;
        misControles.gamplay.Movimiento.canceled += MoverseCanceled;

        //////////////////////////////////////

        //sprin
        misControles.gamplay.Sprin.started += SprinStarted;
        misControles.gamplay.Sprin.canceled += SprinCanceled;

        //////////////////////////////////////

        //Zoom
        misControles.gamplay.Zoom.started += ZoomStarted;
        misControles.gamplay.Zoom.canceled += ZoomCanceled;

        //Giroscopio
        misControles.gamplay.pRUEBA.performed += PRUEBA_started;
    }

    private void PRUEBA_started(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector3>());
    }




    //Zoom
    private void ZoomStarted(InputAction.CallbackContext obj)
    {
        camaraNormal.SetActive(false);
        camaraZoom.SetActive(true);
    }
    private void ZoomCanceled(InputAction.CallbackContext obj)
    {
        camaraNormal.SetActive(true);
        camaraZoom.SetActive(false);
    }
    //sprin
    private void SprinStarted(InputAction.CallbackContext obj)
    {
        corriendo = true;
    }
    private void SprinCanceled(InputAction.CallbackContext obj)
    {
        corriendo = false;
    }

    // movimiento
    private void MoverseStarted(InputAction.CallbackContext valor)
    {
        Vector2 inpunt = valor.ReadValue<Vector2>();

        movimientoVertical = new Vector3(inpunt.x, 0, inpunt.y);
    }
    private void MoverseCanceled(InputAction.CallbackContext valor)
    {
        Vector2 inpunt = valor.ReadValue<Vector2>();

        movimientoVertical = new Vector3(inpunt.x, 0, inpunt.y);
    }
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       ActualizarMovimiento();
    }

    private void FixedUpdate()
    {
        //controle
        transform.Rotate(Vector3.up * movimientoVertical.x * velocidadRotacion * Time.deltaTime);
        controller.Move(transform.forward * movimientoVertical.z* velocidadMovimiento * Time.deltaTime);
        controller.Move(movimientoVertical * Time.deltaTime);
    }
    void ActualizarMovimiento()
    {
        AplicarGravedad();
        //Mover();

        if (corriendo)
        {
            AumentarVelocidades();
        }
        else
        {
            ResetearVelocidades();
        }
    }
    void AumentarVelocidades()
    {
        velocidadRotacion = velocidadCorrerRotacion;
        velocidadMovimiento = velocidadCorrer;


    }

    private void ResetearVelocidades()
    {
        velocidadRotacion = velocidadAndarRotacion;
        velocidadMovimiento = velocidadAndar;
    }

    void AplicarGravedad()
    {
        movimientoVertical.y += Physics.gravity.y * factorGravedad * Time.deltaTime;
        bool enSuelo = Physics.CheckSphere(pies.position,radioDeteccion,queSuelo);

        if (enSuelo)
        {
            movimientoVertical.y = 0;
        }
    }

    
}