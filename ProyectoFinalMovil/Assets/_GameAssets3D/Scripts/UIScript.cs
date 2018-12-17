using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    [SerializeField] Text txtMaxPuntuacion;
    [SerializeField] GameObject btnEscena2;
    int maxPunt;
    


    private void Awake()
    {
        maxPunt = GameControllerPPref.GetPuntos();

        if (maxPunt != 0)
        {
            btnEscena2.gameObject.SetActive(true);
        }
        else
        {
            btnEscena2.gameObject.SetActive(false);
        }
    }


    // Use this for initialization
    void Start () {
       
        
        //maxPunt= GameControllerPPref.GetPuntos();
        txtMaxPuntuacion.text = "Máxima Puntuacion: " + maxPunt; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BotonSeleccionNiveles() {
        SceneManager.LoadScene(1);
    }
    public void BotonInicioNivel1()
    {
        SceneManager.LoadScene(2);
    }
    public void BotonInicioNivel2() {
        SceneManager.LoadScene(3);
    }

    public void BotonExit() {
        Application.Quit();
    }

    public void Fincamara()
    {
        
        SceneManager.LoadScene(1);
    }

  
}
