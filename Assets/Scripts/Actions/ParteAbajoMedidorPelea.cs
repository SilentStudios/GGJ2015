using UnityEngine;
using System.Collections;

public class ParteAbajoMedidorPelea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Entrando parte abajo");
	}

	void OnTriggerExit2D(Collider2D collider){
		Debug.Log ("Saliendo parte abajo");
	}
}
