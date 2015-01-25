using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActionTextListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        //EventServer.ChangeActionEvent += ChangeText;
    }

    private void ChangeText(string text)
    {
        Text label = GetComponent<Text>();
        if (label)
            label.text = "Action: " + text;
    }
}
