using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasDance : MonoBehaviour {

    public Text m_keystring;

    const float TIME_BETWEEN_QTE = 2;
    const float TIME_QTE = 1.0f;
    float m_elapsedTime;

    public enum QTEState
    {
        HIDE = 0,
        SHOWED,
        COMPLETED
    }
    private QTEState m_state;
    protected QTEState state { get { return m_state; } set { m_state = value; } }

    KeyCode m_currentKeyCode;

	// Use this for initialization
	void Start () {
        m_elapsedTime = 0;
        m_currentKeyCode = InputManager.GetRandomKeyCodeArrow();
        m_keystring.gameObject.SetActive(true);
        m_keystring.text = m_currentKeyCode.ToString();
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

    private void HideState()
    {
        if (m_elapsedTime >= TIME_BETWEEN_QTE)
        {
            m_elapsedTime = 0;
            m_currentKeyCode = InputManager.GetRandomKeyCodeArrow();
            m_keystring.color = Color.black;
            m_keystring.text = m_currentKeyCode.ToString();
            state = QTEState.SHOWED;
        }
    }

    private void ShowedState()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(m_currentKeyCode))
            {
                m_keystring.color = Color.green;
            }
            else
            {
                m_keystring.color = Color.red;
            }
            state = QTEState.HIDE;
        }

        if (m_elapsedTime >= TIME_QTE)
        {
            state = QTEState.HIDE;
        }
    }
}
