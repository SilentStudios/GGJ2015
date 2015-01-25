using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DebugText : MonoBehaviour {

    void OnEnable()
    {
        EventServer.SendTextEvent += SetText;
    }

    void OnDisable()
    {
        EventServer.SendTextEvent -= SetText;
    }

    void SetText(string text)
    {
        Text label = GetComponent<Text>();
        if (label)
            label.text = text;
    }

    
}
