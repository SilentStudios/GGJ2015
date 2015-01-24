using UnityEngine;
using System.Collections;

public class EventServer 
{
    public delegate void StringEvent(string text);
    public static event StringEvent SendTextEvent;

    public static void SendText(string text)
    {
        Debug.Log("SendTextEvent: " + text);
        if (SendTextEvent != null)
            SendTextEvent(text);
    }
}
