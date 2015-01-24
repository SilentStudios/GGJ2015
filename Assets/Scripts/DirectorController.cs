using UnityEngine;
using System.Collections;

public class DirectorController : MonoBehaviour {

    public ActorController m_actor;
    //public ActorAction m_nextAction;
    //public Ambient m_nextAmbient;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.AddComponent<RainBehaviour>();
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

        }
	
	}
}
