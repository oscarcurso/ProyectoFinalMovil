using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PunyoScript : MonoBehaviour
{

    public Animator elvisAnimator1;
    public NavMeshAgent agenteElvis1;
    public Animator elvisAnimator2;
    public NavMeshAgent agenteElvis2;
    public Animator elvisAnimator3;
    public NavMeshAgent agenteElvis3;
    public Animator elvisAnimator4;
    public NavMeshAgent agenteElvis4;
    public Animator abuelaAnimator1;
    public NavMeshAgent agenteAbuela1;
    public Animator abuelaAnimator2;
    public NavMeshAgent agenteAbuela2;
    public Animator abuelaAnimator3;
    public NavMeshAgent agenteAbuela3;
    public Animator abuelaAnimator4;
    public NavMeshAgent agenteAbuela4;
    public Animator chicaAnimator1;
    public NavMeshAgent agenteChica1;
    public Animator chicaAnimator2;
    public NavMeshAgent agenteChica2;
    public Animator chicaAnimator3;
    public NavMeshAgent agenteChica3;

    public Text txtvida;
    public Text txtPuntos;
    private int puntos = 0;
    public AudioSource audioPunyo;
    int puntuacionAlmacenada;
    int puntuacionActual;


    private void Awake()
    {
       //PlayerPrefs.DeleteAll();
        puntuacionAlmacenada = GameControllerPPref.GetPuntos();
    }

    void Start()
    {
        puntuacionActual = puntuacionAlmacenada;

        if (puntuacionActual != 0)
        {
            txtPuntos.text = "Puntuación: " + puntuacionActual;
            
        }
        else
        {
            txtPuntos.text = "Puntuación: " + puntos;
            
        }
        
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Elvis1")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            elvisAnimator1.SetBool("ostiado", true);
            agenteElvis1.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Elvis2")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            elvisAnimator2.SetBool("ostiado", true);
            agenteElvis2.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Elvis3")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            elvisAnimator3.SetBool("ostiado", true);
            agenteElvis3.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }

        if (collider.gameObject.name == "Elvis4") {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            elvisAnimator4.SetBool("ostiado", true);
            agenteElvis4.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }

        if (collider.gameObject.name == "Abuela1")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            abuelaAnimator1.SetBool("ostiado", true);
            agenteAbuela1.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Abuela2")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            abuelaAnimator2.SetBool("ostiado", true);
            agenteAbuela2.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Abuela3")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            abuelaAnimator3.SetBool("ostiado", true);
            agenteAbuela3.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Abuela4")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            abuelaAnimator4.SetBool("ostiado", true);
            agenteAbuela4.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Chica1")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            chicaAnimator1.SetBool("ostiado", true);
            agenteChica1.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Chica2")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            chicaAnimator2.SetBool("ostiado", true);
            agenteChica2.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
        if (collider.gameObject.name == "Chica3")
        {
            audioPunyo.Play();
            txtPuntos.text = "Puntos: " + puntuacionActual++;
            chicaAnimator3.SetBool("ostiado", true);
            agenteChica3.isStopped = true;
            GameControllerPPref.StorePuntos(puntuacionActual);

        }
    }


}
