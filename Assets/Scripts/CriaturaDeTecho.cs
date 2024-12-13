using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CriaturaDeTecho : MonoBehaviour
{
    [SerializeField] private Jugador Jugador;
    private NavMeshAgent agent;
    [SerializeField] private Transform puntoDeteccion;
    [SerializeField] private Vector3 zonaDeteccion;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private LayerMask queEsJugador;
    [SerializeField] private float radioAtaque;
    [SerializeField] private Transform puntoDeAtaque;
    [SerializeField] private Transform puntoSubida;
    private float timer;

    private Rigidbody rb;
    // Start is called before the first frame update

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        bool enSuelo = Physics.Raycast(transform.position, new Vector3(0, -1, 0), 0.25f,queEsSuelo);

        if (enSuelo)
        {
            agent.enabled= true;

            agent.SetDestination(Jugador.transform.position);

            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                EnfocarObjetivo();
                //agent.isStopped = true;
            }
        }

        Subir();
    }

    private void EnfocarObjetivo()
    {
        Vector3 direccionAPlayer = (Jugador.transform.position - transform.position).normalized;

        direccionAPlayer.y = 0;

        Quaternion anguloAPlayer = Quaternion.LookRotation(direccionAPlayer);

        transform.rotation = anguloAPlayer;



    }

    private void Subir()
    {
        Collider[] collsDetectado = Physics.OverlapSphere(puntoDeAtaque.position, radioAtaque, queEsJugador);

        if (collsDetectado.Length > 0)
        {
            //Debug.Log("morgan");
            transform.position = puntoSubida.position;
            transform.rotation = puntoSubida.rotation;

            transform.SetParent(puntoSubida);

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(puntoDeAtaque.position, radioAtaque);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.isKinematic = false;

        }
    }


}
