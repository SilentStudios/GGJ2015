using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DanceActionActor : ActionActor {

    

    

    
    

	// Use this for initialization
	void Start () {
        m_ui = Resources.Load("Prefabs/UI/CanvasDance") as GameObject;
        m_ui = Instantiate(m_ui) as GameObject;
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isIdleBaile", true);
        
	}
	
	// Update is called once per frame
	void Update () {
        
        

	}

	void OnDisable()
	{
		GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isIdleBaile", false);
	}

    

    void OnDestroy()
    {
        Destroy(m_ui);
    }

}
