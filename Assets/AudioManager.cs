using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioClip[] audios;
    int index;

	// Use this for initialization
	void Start () {
        index = 0;
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audios[index];
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (!audioSource.isPlaying)
        {
            if (index < audios.Length)
            {
                ++index;
                GetComponent<EventMusic>().SendEvent(EventMusic.MusicType.EPIC);
                audioSource.clip = audios[index];
                audioSource.Play();
            }
            
        }

	    
	}
}
