﻿using UnityEngine;
using System.Collections;

public class EventServer 
{
    public delegate void SimpleEvent();
    public static event SimpleEvent FinishDirectorTimeEvent;
    public static event SimpleEvent StartDirectorTimeEvent;

    public delegate void StringEvent(string text);
    public static event StringEvent SendTextEvent;

    public delegate void ActionEvent(ActionActor action);
    public static event ActionEvent ChangeActionEvent;

    public delegate void AmbientEvent(Ambient ambient);
    public static event AmbientEvent ChangeAmbientEvent;

    public delegate void FloatEvent(float f);
    public static event FloatEvent AddFightSuccessEvent;
    public static event FloatEvent AddTimeEvent;

    public static void SendText(string text)
    {
        //Debug.Log("SendTextEvent: " + text);
        if (SendTextEvent != null)
            SendTextEvent(text);
    }

    public static void AddFightSuccess(float f)
    {
        //Debug.Log("AddFightSuccess: " + f.ToString());
        if (AddFightSuccessEvent != null)
            AddFightSuccessEvent(f);
    }

    public static void AddTime(float f)
    {
        //Debug.Log("AddTime: " + f.ToString());
        if (AddTimeEvent != null)
            AddTimeEvent(f);
    }

    public static void FinishDirectorTime()
    {
        if (FinishDirectorTimeEvent != null)
            FinishDirectorTimeEvent();
    }

    public static void ChangeAction(ActionActor text)
    {
        if (ChangeActionEvent != null)
            ChangeActionEvent(text);
    }

    public static void ChangeAmbient(Ambient text)
    {
        if (ChangeAmbientEvent != null)
            ChangeAmbientEvent(text);
    }

	public static void DirectorTime()
	{
		if (StartDirectorTimeEvent != null) {
			StartDirectorTimeEvent();
				}
	}
}
