using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ProyectilScript : MonoBehaviour {

    [SerializeField] Text txtPuntos;
    [SerializeField] Text txtVida;
    Enemigostontos scriptEnemigo;
    



    private void Start() {




       
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject objetivoImpacto = other.gameObject;

        if (objetivoImpacto.CompareTag("Terrain"))
        {


            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);






    }

      



        
    }







