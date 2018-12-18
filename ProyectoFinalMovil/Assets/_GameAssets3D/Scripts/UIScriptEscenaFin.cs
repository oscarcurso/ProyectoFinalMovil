using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScriptEscenaFin : MonoBehaviour
{

    //[SerializeField] Text txtPuntos;
    //[SerializeField] Text txtVidas;
    // Use this for initialization
    void Start()
    {
        //txtPuntos.text = GameControllerPPref.GetPuntos().ToString();
        //txtVidas.text = GameControllerPPref.GetVidas().ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("Fire1");
            SceneManager.LoadScene(1);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Application.Quit();
        }

    }
    public void CamaraFinal()
    {
        SceneManager.LoadScene(1);
        
    }
}
