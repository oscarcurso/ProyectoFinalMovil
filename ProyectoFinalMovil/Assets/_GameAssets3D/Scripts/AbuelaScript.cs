using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AbuelaScript : MonoBehaviour {
    public Text textVida;
    public Text textPuntos;
    

    Animator miAnimator;
    public GameObject player;
    public Transform[] puntosPatrulla = new Transform[5];
    NavMeshAgent agente;
    enum Estado { Andando, Siguiendo, Ostiado };
    Estado estado = Estado.Andando;

    float anguloVision = 50;
    float distanciaVision = 7;


    void Start() {
        agente = GetComponent<NavMeshAgent>();
        miAnimator = GetComponent<Animator>();
     
        AsignarPuntoPatrulla();


    }
    void Update() {

        VerificarObjectivo();


        switch (estado) {


            case Estado.Andando:
                miAnimator.SetBool("corriendo", false);
                ComprobarDestino();
                break;

            case Estado.Siguiendo:
                agente.destination = player.transform.position;
                miAnimator.SetBool("corriendo", true);
                agente.speed = agente.speed + 0.2f;



                break;

            case Estado.Ostiado:
                miAnimator.SetBool("ostiado", true);
                agente.isStopped = true;

                break;

        }
        
    }

    private void VerificarObjectivo() {
        float distancia = Vector3.Distance(transform.position, player.transform.position);
        Vector3 direccion = Vector3.Normalize(player.transform.position - transform.position);
        float angulo = Vector3.Angle(direccion, transform.forward);
        if (distancia < distanciaVision && angulo < anguloVision) {
            //Debug.DrawLine(transform.position, player.transform.position, Color.red, 1);
            //RaycastHit rch;
            estado = Estado.Siguiendo;

        } else {
            estado = Estado.Andando;
        }




    }

    private void ComprobarDestino() {
        if (!agente.pathPending) {
            if (agente.remainingDistance <= agente.stoppingDistance + 0.1) {

                estado = Estado.Andando;
                Invoke("AsignarPuntoPatrulla", 1);
            }
        }
    }
    private void AsignarPuntoPatrulla() {

        int pp = Random.Range(0, puntosPatrulla.Length);
        agente.destination = puntosPatrulla[pp].position;
        estado = Estado.Andando;

    }
    void Destruccion()
    {
        Destroy(this.gameObject);
    }
    void DestruirPersonaje()
    {
        Invoke("Destruccion", 1);
    }






}
