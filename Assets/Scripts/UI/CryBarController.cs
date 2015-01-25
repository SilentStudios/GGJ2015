using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CryBarController : MonoBehaviour {
	public Slider sliderTime;
	public Slider sliderPush;
	private float m_time;
	private KeyCode key;

	// Use this for initialization
	void Start () {
		m_time = 0.0f;
		key = InputManager.GetRandomKeyCode ();
		sliderTime.GetComponentInChildren<Text> ().text = key.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		m_time += Time.deltaTime;
		if (m_time >= 5.0f) {
			ResetComponent();
			// Mandar puntuacion
		} else {
			sliderTime.value = Mathf.Clamp(m_time/5.0f, 0, 1);
		}

		if (Input.GetKey(key)) {
			sliderPush.value += 0.005f;
			GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAccionLlanto", true);
		}

		if (Input.GetKeyUp (key)) {
			GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAccionLlanto", false);
		}
	}

	void ResetComponent() {
		m_time = 0.0f;
		sliderPush.value = 0.0f;
		key = InputManager.GetRandomKeyCode ();
		sliderTime.GetComponentInChildren<Text> ().text = key.ToString();
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAccionLlanto", false);
	}

	void OnDisable() {
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isAccionLlanto", false);
	}
}
