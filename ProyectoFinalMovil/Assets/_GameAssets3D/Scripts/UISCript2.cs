using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISCript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
    public void BotonExit()
    {
        Application.Quit();
    }
    public void BotonSeleccionNiveles()
    {
        SceneManager.LoadScene(1);
    }
}
