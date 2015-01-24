using UnityEngine;
using System.Collections;

public class AmbientMusic : MonoBehaviour {

    public enum MusicType
    {
        EPIC = 0,
        DRAMA,
        COMEDY,
        SUSPENSE,
        COUNT,
    }

    public int m_EpicSecond;
    public AudioSource m_music;


    private MusicType m_musicType;
    public MusicType musicType { get { return m_musicType; } }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void ChangeMusicType(MusicType type)
    {
        m_musicType = type;
    }
}
