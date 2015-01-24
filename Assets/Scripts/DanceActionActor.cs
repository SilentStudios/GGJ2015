using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DanceActionActor : ActionActor {

    const float TIME_BETWEEN_QTE = 2;
    const float TIME_QTE = 1.0f;

    

    KeyCode m_currentKeyCode;
    

	// Use this for initialization
	void Start () {

        m_elapsedTime = 0;
        m_currentKeyCode = InputManager.GetRandomKeyCodeArrow();
        EventServer.SendText(m_currentKeyCode.ToString());
        state = QTEState.SHOWED;
	}
	
	// Update is called once per frame
	void Update () {
        m_elapsedTime += Time.deltaTime;
        switch (state)
        {
            case QTEState.SHOWED:
                ShowedState();
                break;

            case QTEState.HIDE:
                HideState();
                break;

            default:
                break;
        }
        

	}

    private void CompletedState()
    {
        throw new System.NotImplementedException();
    }

    private void HideState()
    {
        if (m_elapsedTime >= TIME_BETWEEN_QTE)
        {
            m_elapsedTime = 0;
            m_currentKeyCode = InputManager.GetRandomKeyCodeArrow();
            EventServer.SendText(m_currentKeyCode.ToString());
            state = QTEState.SHOWED;
        }
    }

    private void ShowedState()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(m_currentKeyCode))
            {
                EventServer.SendText("Correcto");
            }
            else
            {
                EventServer.SendText("Incorrecto");
            }
            state = QTEState.HIDE;
        }

        if (m_elapsedTime >= TIME_QTE)
        {
            state = QTEState.HIDE;
        }
    }

}
