using UnityEngine;
using System.Collections;

public class ParteArribaMedidorPelea : MonoBehaviour {
    public GameObject goToActivate;
	private bool m_isInside = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) && m_isInside) {
			GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAtaqueArribaPelea", true);
			m_isInside = false;
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider){
        goToActivate.SetActive(true);
		m_isInside = true;
	}
	
	void OnTriggerExit2D(Collider2D collider){
        goToActivate.SetActive(false);
		m_isInside = false;
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAtaqueArribaPelea", false);
	}

	void OnDisable() {
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isAtaqueArribaPelea", false);
	}
}
