using UnityEngine;
using System.Collections;

public abstract class ActionActor : MonoBehaviour {
    
    protected GameObject m_ui;

    protected float m_elapsedTime;

    public enum QTEState
    {
        HIDE = 0,
        SHOWED,
        COMPLETED
    }
    private QTEState m_state;
    protected QTEState state { get { return m_state; } set { m_state = value; } }

    void Start()
    {
        
    }
}
