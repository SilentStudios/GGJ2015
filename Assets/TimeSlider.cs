using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class TimeSlider : MonoBehaviour {

    public float m_totalTime;

    protected float m_elapsedTime;

    protected bool m_isCompleted;
    public bool isCompleted { get { return m_isCompleted; } }
    public float progress { get { return m_elapsedTime / m_totalTime; } }

	// Use this for initialization
	void Start () {
        m_elapsedTime = 0;
	}
	
	// Update is called once per frame
    void Update()
    {
        m_elapsedTime += Time.deltaTime;
        GetComponent<Slider>().value = m_elapsedTime / m_totalTime;
        if (m_elapsedTime > m_totalTime)
        {
            m_isCompleted = true;
        }
    }

    public void Reset()
    {
        m_elapsedTime = 0.0f;
        GetComponent<Slider>().value = 0;
        m_isCompleted = false;
    }
}
