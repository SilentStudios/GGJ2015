using UnityEngine;
using System.Collections;

public abstract class ActionActor : MonoBehaviour {

    protected GameObject m_ui;
    protected float m_elapsedTime;


    void OnDestroy()
    {
        Destroy(m_ui);
    }

	void OnDisable()
	{
	}
}
