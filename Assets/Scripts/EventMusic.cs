﻿using UnityEngine;
using System.Collections;

public class EventMusic : MonoBehaviour {

    public enum MusicType
    {
        EPIC = 0,
        DRAMA,
        COMEDY,
        SUSPENSE,
        COUNT,
    }

    private float m_lastKeyFrame;

    private MusicType m_musicType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Animator animator = GetComponent<Animator>();
        //Debug.Log(animator.animation);
	}

    public void SendEvent(MusicType type)
    {
        Debug.Log(type);
        if (type == MusicType.COUNT)
            return;

        m_musicType = type;
        m_lastKeyFrame = audio.time;
        GetComponent<Animator>().enabled = false;
        StartCoroutine("WaitUntilDirectorChoise");


        //Debug.Log("Music: " + audio.time + ", Animation: ");
    }

    IEnumerator WaitUntilDirectorChoise()
    {
        GetComponent<DirectorController>().enabled = true;
        yield return new WaitForSeconds(5);
        GetComponent<Animator>().enabled = true;
    }
    
}