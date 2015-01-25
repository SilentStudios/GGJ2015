using UnityEngine;
using System.Collections;

public class ParteAbajoMedidorPelea : MonoBehaviour {
    public GameObject goToActivate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Entrando parte abajo");
        goToActivate.SetActive(true);
	}

	void OnTriggerExit2D(Collider2D collider){
		Debug.Log ("Saliendo parte abajo");
        goToActivate.SetActive(false);

	}
}
