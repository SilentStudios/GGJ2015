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

        EventServer.SendText(m_actor.GetComponent<ActionActor>().GetType().ToString());

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
        EventServer.AddTime(Time.deltaTime / 5.0f);
        // Capture ambient decision.
        if (Input.GetKeyDown(KeyCode.W))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<RainBehaviour>().ToString());
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<BalloonBehaviour>().ToString());
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<StormBehaviour>().ToString());
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<DarknessBehaviour>().ToString());
        }

        EventServer.SendText(gameObject.GetComponent<Ambient>().GetType().ToString());

        // Capture action decision.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<DanceActionActor>().enabled = false;
            EventServer.ChangeAction("Dance");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<FightActionActor>().enabled = false;
            EventServer.ChangeAction("Fight");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<StealthActionActor>().enabled = false;
            EventServer.ChangeAction("Stealth");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RemoveActionActor();
            m_actor.AddComponent<CryActionActor>().enabled = false;
            EventServer.ChangeAction("Cry");
        }

        EventServer.SendText(m_actor.GetComponent<ActionActor>().GetType().ToString());
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
