using UnityEngine;
using System.Collections;

public class EventServer 
{
    public delegate void SimpleEvent();
    public static event SimpleEvent FinishDirectorTimeEvent;
    public static event SimpleEvent StartDirectorTimeEvent;

    public delegate void StringEvent(string text);
    public static event StringEvent SendTextEvent;
    public static event StringEvent ChangeActionEvent;
    public static event StringEvent ChangeAmbientEvent;

    public delegate void FloatEvent(float f);
    public static event FloatEvent AddFightSuccessEvent;
    public static event FloatEvent AddTimeEvent;

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

    public static void AddTime(float f)
    {
        Debug.Log("AddTime: " + f.ToString());
        if (AddTimeEvent != null)
            AddTimeEvent(f);
    }

    public static void FinishDirectorTime()
    {
        if (FinishDirectorTimeEvent != null)
            FinishDirectorTimeEvent();
    }

    public static void ChangeAction(string text)
    {
        if (ChangeActionEvent != null)
            ChangeActionEvent(text);
    }

    public static void ChangeAmbient(string text)
    {
        if (ChangeAmbientEvent != null)
            ChangeAmbientEvent(text);
    }
}
