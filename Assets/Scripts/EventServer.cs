using UnityEngine;
using System.Collections;

public class EventServer 
{
    public delegate void StringEvent(string text);
    public static event StringEvent SendTextEvent;

    public delegate void FloatEvent(float f);
    public static event FloatEvent AddFightSuccessEvent;

    public static void SendText(string text)
    {
        Debug.Log("SendTextEvent: " + text);
        if (SendTextEvent != null)
            SendTextEvent(text);
    }

    public static void AddFightSuccess(float f)
    {
        Debug.Log("AddFightSuccess: " + f.ToString());
        if (AddFightSuccessEvent != null)
            AddFightSuccessEvent(f);
    }
}
