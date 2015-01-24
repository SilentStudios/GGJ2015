using UnityEngine;
using System.Collections;

public class RainBehaviour : MonoBehaviour {

    private GameObject m_rain;

	// Use this for initialization
	void Start () {
        m_rain = Resources.Load("Assets/Thelastofus/rain") as GameObject;
        m_rain = Instantiate(m_rain) as GameObject;

        // El escenario tiene toda la mierda necesaria
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
