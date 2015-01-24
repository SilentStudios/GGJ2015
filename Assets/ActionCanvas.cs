using UnityEngine;
using System.Collections;

public class ActionCanvas : MonoBehaviour {

    void OnEnable()
    {
        EventServer.StartDirectorTimeEvent += Finish;
    }

    private void Finish()
    {
        Destroy(gameObject);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
