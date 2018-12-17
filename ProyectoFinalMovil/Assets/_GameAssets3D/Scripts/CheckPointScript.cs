using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour {

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.name == "Player") {

            GameControllerPPref.StorePosition(collision.gameObject.transform.position);


            Destroy(this.gameObject);
        }
    }
}
