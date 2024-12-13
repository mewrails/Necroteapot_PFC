using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;
    private Transform cam;
    private Vector3 direccionMovimiento;
    private Vector3 movimientoVertical;


    

    [Header("Movimiento")]
    [SerializeField] private float velocidad;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private float alturaSalto;
    [SerializeField] private float fuerzaGravedad;
    


    void Start()
    {
        
        cam = Camera.main.transform;
    }
    private void Awake()
    {
        controller = GetComponent<CharacterController>();

    }


    void Update()
    {
        Movimiento();
        AplicarGravedad();
    }
    private void Movimiento()
    {
        Salto();
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        direccionMovimiento = cam.transform.forward * inputV + cam.transform.right * inputH;

        direccionMovimiento.y = 0;

        controller.Move(direccionMovimiento.normalized * velocidad * Time.deltaTime);

        transform.eulerAngles = new Vector3(0, cam.transform.eulerAngles.y, 0);


    }
    private void Salto()
    {
        if (EnSuelo())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movimientoVertical.y = Mathf.Sqrt(-2 * Physics.gravity.y * fuerzaGravedad * alturaSalto);

            }
            if(movimientoVertical.y < 0)
            {

                movimientoVertical.y = 0;
            }
            
        }
    }
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
