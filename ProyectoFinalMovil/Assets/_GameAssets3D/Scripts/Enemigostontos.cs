using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemigostontos : MonoBehaviour {

    [SerializeField]  int tiempoEntreRotacion = 2;
    [SerializeField] int inicioRotacion = 1;
    
    public Camera camaraPpal;
    public Camera camaraSec;
    int puntos;
    int vidas;
    public AudioSource audioPrimero;

    [SerializeField] Text txtVidas;
    [SerializeField] Text txtPuntos;
    int puntosAlmacenados;
    int vidasAlmacenadas;
     public UIScriptEscenaFin escenaFinScript;



    private void Awake()
    {
        
        camaraSec.gameObject.SetActive(false);
       
        
            puntosAlmacenados = GameControllerPPref.GetPuntos();
            vidasAlmacenadas = GameControllerPPref.GetVidas();
            vidas = vidasAlmacenadas;
            puntos = puntosAlmacenados;
            txtPuntos.text = "Puntos: " + puntos;
            txtVidas.text = "Vidas: " + vidas;
        
    }


    void Start() {
        
        
        InvokeRepeating("RotarAleatoriamente", inicioRotacion, tiempoEntreRotacion);

    }

     void Update() {
        if (puntos >= puntosAlmacenados + 5) {
            SaludoFinal();

        }

        Avanzar();
       
       

    }

    private void SaludoFinal() {
        GameControllerPPref.StorePuntos(puntosAlmacenados + 5);
        audioPrimero.Stop();
        camaraPpal.gameObject.SetActive(false);
        camaraSec.gameObject.SetActive(true);
        escenaFinScript.enabled = false;
    }

    public void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);

        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }

    public void Avanzar() {

        int speed = 1;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        

    }

    public void Destruir()
    {
        Destroy(this);
    }



    private void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.CompareTag("Proyectil"))
        {
            Debug.Log("Impacto Proyectil");



            puntos = puntos + 1;
            txtPuntos.text = "Puntuacion: " + puntos;


            GetComponent<Animator>().SetBool("ostiado", true);
           
            print("cogiendo puntos");
            








        }

      
    }
    void Destruccion()
    {
       
        GetComponent<Rigidbody>().AddRelativeForce(0, 1000, 2000);
    }
   
    
}

   

