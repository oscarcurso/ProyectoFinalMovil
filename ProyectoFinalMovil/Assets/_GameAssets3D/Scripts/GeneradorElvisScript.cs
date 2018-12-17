using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorElvisScript : MonoBehaviour {

    [SerializeField] GameObject prefabElvis;
	// Use this for initialization
	void Start () {
        Invoke("GeneradorElvis", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void GeneradorElvis() {

        Instantiate(prefabElvis, transform.position, Quaternion.identity);
    }
}
