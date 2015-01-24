using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FightActionActor : ActionActor {

    KeyCode m_currentKey1;
    KeyCode m_currentKey2;
    bool one;

	// Use this for initialization
	void Start() {
        one = true;
        m_elapsedTime = 0;
        m_currentKey1 = InputManager.GetRandomKeyCodeArrow();
        m_currentKey2 = InputManager.GetRandomKeyCodeArrow();

        while (m_currentKey2 == m_currentKey1) {
			m_currentKey2 = InputManager.GetRandomKeyCodeArrow ();
		}

        EventServer.SendText(m_currentKey1.ToString() + " + " + m_currentKey2.ToString());
	}
	
	// Update is called once per frame
	void Update() {
        if (one)
        {
            if (Input.GetKeyDown(m_currentKey1))
            {
                one = !one;
                EventServer.AddFightSuccess(0.2f);
            }
        }
        else
        {
            if (Input.GetKeyDown(m_currentKey2))
            {
                one = !one;
                EventServer.AddFightSuccess(0.2f);
            }
        }
	    
	}
}
