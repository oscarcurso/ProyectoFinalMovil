using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtilleriaScript : MonoBehaviour
{


    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform puntoGeneracion;

    public float fuerza = 100;
    public AudioSource audioCanyon;





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            GameObject nuevoProyectil = Instantiate(prefabProyectil, puntoGeneracion.transform.position, puntoGeneracion.transform.rotation);
            nuevoProyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * fuerza);
            audioCanyon.Play();
        }



        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-1, 0, 0);
        }



    }

}
