using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJ : MonoBehaviour
{
    //Propiedades
    [SerializeField] private int vida, cordura;
    [SerializeField, Tooltip("Tocar este numerito, suaviza la rotación")] private float suavidadRotacion;
    [SerializeField] private float velocidadAndar, velocidadCorrer;
    [SerializeField] private float velocidadAndarRotacion, velocidadCorrerRotacion;
    [SerializeField] private float velocidadAgachado;
    [SerializeField] private float factorGravedad;
    [SerializeField] private LayerMask esSuelo;

    public CharacterController controller;

    private float velocidadMovimiento;
    private float velocidadRotacion;
    Transform cam;
    Rigidbody rb;

    private Vector3 movimientoVertical;

    private float hInput, vInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        cam = Camera.main.transform;

        velocidadMovimiento = velocidadAndar;
        velocidadRotacion = velocidadAndarRotacion;
  
    }

    
    void Update()
    {
        ActualizarMovimiento();
    }

    //FUNCIONALIDADES

    void ActualizarMovimiento()
    {
        AplicarGravedad();
        Mover();  

        if (Input.GetKey(KeyCode.LeftShift))
        {
            AumentarVelocidades();
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            ResetearVelocidades();
        }

        

    }

    void AplicarGravedad()
    {
        movimientoVertical.y += Physics.gravity.y * factorGravedad * Time.deltaTime;

        if (enSuelo())
        {
            movimientoVertical.y = 0;
        }
    }
    bool enSuelo()
    {
        bool suelo = Physics.Raycast(transform.position, Vector3.down, 0.1f, esSuelo);
        return suelo;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = enSuelo() ? Color.green : Color.red;
        Gizmos.DrawRay(transform.position, Vector3.down * 0.1f);
    }
    void Mover()
    {
         hInput = Input.GetAxisRaw("Horizontal");
         vInput = Input.GetAxisRaw("Vertical");
        Vector3 input = new Vector3(hInput, 0, vInput).normalized;

    }

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * hInput * velocidadRotacion * Time.deltaTime);

        controller.Move(transform.forward * vInput * velocidadMovimiento * Time.deltaTime);
        controller.Move(movimientoVertical * Time.deltaTime);
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

    void Agacharse()
    {

    }

    void CogerObjeto()
    {

    }

}
