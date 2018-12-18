using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScriptEscenaFin : MonoBehaviour {

    //[SerializeField] Text txtPuntos;
    //[SerializeField] Text txtVidas;
	// Use this for initialization
	void Start () {
       //txtPuntos.text = GameControllerPPref.GetPuntos().ToString();
       //txtVidas.text = GameControllerPPref.GetVidas().ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    public void Fincamara()
    {

        SceneManager.LoadScene(5);
    }
}
