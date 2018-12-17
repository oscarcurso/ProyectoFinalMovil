using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Animator miAnimator;
    float corriendo = 0.10f;
    public float speedAndar = 2f;
    public float speedCorrer = 2f;
    public float speedRotar = 5f;
    public float speedRotarParado = 2f;
    private int vidaMaxima;
    private int vidaActual;
    private int danyo;

    public Text txtVida;





    private void Awake()
    {
        vidaMaxima = 10;
        danyo = 1;
        vidaActual = vidaMaxima;

    }




    void Start()
    {
        int vidasGuardadas = GameControllerPPref.GetVidas();
        miAnimator = GetComponent<Animator>();
        GetComponentInChildren<Transform>().gameObject.name = "Puneteador";
        if (vidasGuardadas != 0)
        {
            txtVida.text = "Vidas: " + vidasGuardadas;
        }
        else
        {
            txtVida.text = "Vida: " + vidaActual;
        }

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.Space))
        {
            miAnimator.ResetTrigger("ostiando");
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0.11f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space))
        {
            miAnimator.ResetTrigger("ostiando");
            corriendo = corriendo + 0.01f;
            corriendo = Mathf.Min(1, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        }
        else if (!Input.GetKey(KeyCode.W))
        {
            miAnimator.ResetTrigger("ostiando");
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);

        }
        if (Input.GetMouseButtonDown(0))
        {
            miAnimator.SetTrigger("ostiando");
        }
        if (Input.GetMouseButtonDown(1))
        {
            miAnimator.SetTrigger("saltando");
        }


        if (corriendo >= 0f)
        {

            transform.Rotate(0, Input.GetAxis("Horizontal") * speedRotarParado, 0);
        }
        if (vidaActual <= 0)
        {


            SceneManager.LoadScene(4);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {

            vidaActual = vidaActual - danyo;
            txtVida.text = "Vida: " + vidaActual;
            GameControllerPPref.StoreVidas(vidaActual);
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, 0.9f);

        }
    }





}






