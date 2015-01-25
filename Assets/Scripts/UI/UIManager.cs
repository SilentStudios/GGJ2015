using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    private static UIManager m_instance;
    public static UIManager GetInstance()
    {
        return m_instance;
    }

	// Use this for initialization
	void Start () {
        if (m_instance)
            Destroy(this);
        else
            m_instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
