using UnityEngine;
using System.Collections;

public class DirectorController : MonoBehaviour {

    public GameObject m_actor;
    public Canvas canvas;

    float m_elapsedTime;
	// Use this for initialization
	void OnEnable () {
	    // Random Ambient and Action
        //m_actor.GetComponent<ActionActor>().enabled = false;
        RemoveAmbientComponent();
        
		EventServer.ChangeAmbient(gameObject.AddComponent<RainBehaviour>());
        m_elapsedTime = 0;

        RemoveActionActor();
		ActionActor action = m_actor.AddComponent<DanceActionActor>();
		action.enabled = false;
		EventServer.ChangeAction (action);

        EventServer.SendText(m_actor.GetComponent<ActionActor>().GetType().ToString());
        EventServer.AddTime(0.0f);

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
        m_elapsedTime += Time.deltaTime;
        EventServer.AddTime(m_elapsedTime / 5.0f);
        // Capture ambient decision.
        if (Input.GetKeyDown(KeyCode.D))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<RainBehaviour>());
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<BalloonBehaviour>());
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<StormBehaviour>());
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            RemoveAmbientComponent();
            EventServer.ChangeAmbient(gameObject.AddComponent<DarknessBehaviour>());
        }

        // Capture action decision.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RemoveActionActor();
            ActionActor action = m_actor.AddComponent<DanceActionActor>();
            action.enabled = false;
            EventServer.ChangeAction(action);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RemoveActionActor();
            ActionActor action = m_actor.AddComponent<FightActionActor>();
            action.enabled = false;
            EventServer.ChangeAction(action);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RemoveActionActor();
            ActionActor action = m_actor.AddComponent<StealthActionActor>();
            action.enabled = false;
            EventServer.ChangeAction(action);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemoveActionActor();
            ActionActor action = m_actor.AddComponent<CryActionActor>();
            action.enabled = false;
            EventServer.ChangeAction(action);
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
