using UnityEngine;
using System.Collections;

public class CryActionActor : ActionActor {

	// Use this for initialization
	void Start () {
        m_ui = Resources.Load("Prefabs/UI/CanvasCryBar") as GameObject;
        m_ui = Instantiate(m_ui) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
