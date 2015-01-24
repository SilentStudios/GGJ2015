using UnityEngine;
using System.Collections;

public class DirectorController : MonoBehaviour {

    public GameObject m_actor;
    public Canvas canvas;
	// Use this for initialization
	void OnEnable () {
	    // Random Ambient and Action
        //m_actor.GetComponent<ActionActor>().enabled = false;
        RemoveAmbientComponent();
        gameObject.AddComponent<RainBehaviour>();

        RemoveActionActor();
        m_actor.AddComponent<DanceActionActor>().enabled =false;

        if (canvas) canvas.gameObject.SetActive(true);
	}

    void OnDisable()
    {
        m_actor.GetComponent<ActionActor>().enabled = true;
        if (canvas) canvas.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () 
    {
        // Capture ambient decision.
        if (Input.GetKeyDown(KeyCode.W))
        {
            RemoveAmbientComponent();
            gameObject.AddComponent<RainBehaviour>();
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RemoveAmbientComponent();
            gameObject.AddComponent<BalloonBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            RemoveAmbientComponent();
            gameObject.AddComponent<StormBehaviour>();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RemoveAmbientComponent();
            gameObject.AddComponent<DarknessBehaviour>();
        }

        // Capture action decision.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<DanceActionActor>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<FightActionActor>().enabled = false; 
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<StealthActionActor>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<CryActionActor>().enabled = false;
        }
	}

    void RemoveAmbientComponent()
    {
        Ambient ambient = GetComponent<Ambient>();
        if (ambient)
        {
            Destroy(ambient);
        }
    }

    void RemoveActionActor()
    {
        ActionActor action = m_actor.GetComponent<ActionActor>();
        if (action)
        {
            Destroy(action);
        }
    }
}
