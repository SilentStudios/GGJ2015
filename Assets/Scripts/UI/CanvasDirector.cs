using UnityEngine;
using System.Collections;

public class CanvasDirector : MonoBehaviour {
    public GameObject m_child;

    void OnEnable()
    {
        EventServer.StartDirectorTimeEvent += StartDirectorTime;
        EventServer.FinishDirectorTimeEvent += FinishDirectorTime;
    }

    private void StartDirectorTime()
    {
        m_child.SetActive(true);
    }

    void OnDisable()
    {
        EventServer.StartDirectorTimeEvent -= StartDirectorTime;
        EventServer.FinishDirectorTimeEvent -= FinishDirectorTime;
    }


    private void FinishDirectorTime()
    {
        m_child.SetActive(false);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
