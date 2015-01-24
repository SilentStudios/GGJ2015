using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DanceActionActor : ActionActor {

    

    

    
    

	// Use this for initialization
	void Start () {
        m_ui = Resources.Load("Prefabs/UI/CanvasDance") as GameObject;
        m_ui = Instantiate(m_ui) as GameObject;

        
	}
	
	// Update is called once per frame
	void Update () {
        
        

	}

    

    void OnDestroy()
    {
        Destroy(m_ui);
    }

}
