using UnityEngine;
using UnityEngine.InputSystem; //iclusion del nuevo sistema de inputs

public class Jugador : MonoBehaviour
{

    CharacterController controller;
    private Transform cam;
    private Vector3 direccionMovimiento;
    private Vector3 movimientoVertical;
    //private Controles misControles;
    //bool corriendo;

    //////////////////////////////////////////////
    // Movimiento


    [Header("Movimiento")]
    [SerializeField] private float velocidad, velocidadCorrer;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private float alturaSalto;
    [SerializeField] private float fuerzaGravedad;

   
    

    //////////////////////////////////////////////
    // Gravedad

    [SerializeField] private float factorGravedad,radioDeteccion;
   




    private void Awake() 
    {
        controller = GetComponent<CharacterController>();

    }
    void Start()
    {

        cam = Camera.main.transform;
    }
    

    void Update()
    {
        Movimiento();
        AplicarGravedad();
       
    }
    
    /*private void FixedUpdate()
    {
        //controle
        transform.Rotate(Vector3.up * movimientoVertical.x * velocidadRotacion * Time.deltaTime);
        controller.Move(transform.forward * movimientoVertical.z* velocidadMovimiento * Time.deltaTime);
        controller.Move(movimientoVertical * Time.deltaTime);
    }*/

    private void Movimiento()
    {
        
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        direccionMovimiento = cam.transform.forward * inputV + cam.transform.right * inputH;

        direccionMovimiento.y = 0;

        controller.Move(direccionMovimiento.normalized * velocidad * Time.deltaTime);

        transform.eulerAngles = new Vector3(0, cam.transform.eulerAngles.y, 0);


    }

    // SE ejecuta automaticamente antes de start cada vez
    //se activa el objeto
    /*private void OnEnable()
    {
        //doy valor a la variable para que no se quede null
        misControles = new Controles();

        // esto es para habilitar los controles
        misControles.gamplay.Enable();

        // movimiento
        misControles.gamplay.Movimiento.performed += MoverseStarted;
        misControles.gamplay.Movimiento.canceled += MoverseCanceled;

        //////////////////////////////////////

        //sprint
        misControles.gamplay.Sprin.started += SprinStarted;
        misControles.gamplay.Sprin.canceled += SprinCanceled;

        //////////////////////////////////////

        //Zoom
        misControles.gamplay.Zoom.started += ZoomStarted;
        misControles.gamplay.Zoom.canceled += ZoomCanceled;

        //Giroscopio
        misControles.gamplay.pRUEBA.performed += PRUEBA_started;
    }*/

    private void PRUEBA_started(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector3>());
    }




    //Zoom
    /*private void ZoomStarted(InputAction.CallbackContext obj)
    {
        camaraNormal.SetActive(false);
        camaraZoom.SetActive(true);
    }
    private void ZoomCanceled(InputAction.CallbackContext obj)
    {
        camaraNormal.SetActive(true);
        camaraZoom.SetActive(false);
    }*/

    //sprint
    /*private void SprinStarted(InputAction.CallbackContext obj)
    {
        corriendo = true;
    }
    private void SprinCanceled(InputAction.CallbackContext obj)
    {
        corriendo = false;
    }*/
    
    // movimiento
    /*private void MoverseStarted(InputAction.CallbackContext valor)
    {
        Vector2 inpunt = valor.ReadValue<Vector2>();

        movimientoVertical = new Vector3(inpunt.x, 0, inpunt.y);
    }
    private void MoverseCanceled(InputAction.CallbackContext valor)
    {
        Vector2 inpunt = valor.ReadValue<Vector2>();

        movimientoVertical = new Vector3(inpunt.x, 0, inpunt.y);
    }*/
  
   

    

    
    /*void ActualizarMovimiento()
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
    }*/

   /* void AumentarVelocidades()
    {
        velocidadRotacion = velocidadCorrerRotacion;
        velocidadMovimiento = velocidadCorrer;


    }

    private void ResetearVelocidades()
    {
        velocidadRotacion = velocidadAndarRotacion;
        velocidadMovimiento = velocidadAndar;
    }*/

    /*void AplicarGravedad()
    {
        movimientoVertical.y += Physics.gravity.y * factorGravedad * Time.deltaTime;
        bool enSuelo = Physics.CheckSphere(pies.position,radioDeteccion,queSuelo);

        if (enSuelo)
        {
            movimientoVertical.y = 0;
        }
    }*/
    private void AplicarGravedad()
    {

        movimientoVertical.y += Physics.gravity.y * fuerzaGravedad * Time.deltaTime;
        controller.Move(movimientoVertical * Time.deltaTime);

        if (EnSuelo() == true)
        {
            movimientoVertical.y = 0;
        }

    }
    private bool EnSuelo()
    {
        bool estoyEnSuelo = Physics.Raycast(transform.position, Vector3.down, 1.25f, queEsSuelo);
        return estoyEnSuelo;
    }
}