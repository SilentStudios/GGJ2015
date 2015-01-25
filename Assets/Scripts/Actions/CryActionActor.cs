using UnityEngine;
using System.Collections;

public class CryActionActor : ActionActor {

	// Use this for initialization
	void Start () {
        m_ui = Resources.Load("Prefabs/UI/CanvasCryBar") as GameObject;
        m_ui = Instantiate(m_ui) as GameObject;
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isIdleLlanto", true);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnEnable()
	{
		EventServer.StartDirectorTimeEvent += FalseBool;
		}

	void FalseBool()
	{

		}

	void OnDisable() {
		Debug.Log ("ESTOY DESACTIVaNDO");
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isIdleLlanto", false);
		EventServer.StartDirectorTimeEvent -= FalseBool;
	}
}
