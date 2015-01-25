using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour {

    public KeyCode m_keyCode;
    public KeyCode keyCode 
    {   
        get 
        { 
            return m_keyCode; 
        } 
        set 
        { 
            m_keyCode = value; GetComponentInChildren<Text>().text = keyCode.ToString(); 
        } 
    }

    private bool m_isPushed;
    public bool isPushed { get{ return m_isPushed;} }

	// Use this for initialization
	void Start () {
        GetComponentInChildren<Text>().text = keyCode.ToString();
        m_isPushed = false;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            m_isPushed = true;
            gameObject.SetActive(false);
        }
        else
        {
            //m_isPushed = false;
        }
    }

}
