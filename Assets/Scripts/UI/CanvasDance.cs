using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasDance : MonoBehaviour {

    public ArrowButton m_keystring;

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
		m_keystring.changeSprite (m_currentKeyCode);
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
			m_keystring.changeSprite(m_currentKeyCode);
			m_keystring.GetComponent<Image>().color = Color.white;
            
            state = QTEState.SHOWED;
        }
    }

    string GetStringFromArrow(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.DownArrow:
                return "v";

            case KeyCode.UpArrow:
                return "^";

            case KeyCode.LeftArrow:
                return "<";

            case KeyCode.RightArrow:
                return ">";

            default:
                return keyCode.ToString();
        }
    }

    private void ShowedState()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(m_currentKeyCode))
            {
				m_keystring.PushCorrect();
				GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isAccionBaile", true);
				StartCoroutine("desactiveAnimatorWithDelay");
            }
            else
            {
				m_keystring.PushIncorrect();
            }
            state = QTEState.HIDE;
        }

        if (m_elapsedTime >= TIME_QTE)
        {
            state = QTEState.HIDE;
        }
    }

	void OnDisable(){
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isAccionBaile", false);
	}

	IEnumerator desactiveAnimatorWithDelay() 
	{
		yield return new WaitForSeconds(0.2f);
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ().SetBool ("isAccionBaile", false);
	}
}
