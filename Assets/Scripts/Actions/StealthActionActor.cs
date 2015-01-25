using UnityEngine;
using System.Collections;

public class StealthActionActor : ActionActor {

	// Use this for initialization
	void Start () {
        m_ui = Resources.Load("Prefabs/UI/CanvasStealth") as GameObject;
        m_ui = Instantiate(m_ui) as GameObject;
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isIdleSigilo", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy()
    {
        Destroy(m_ui);
    }
}
