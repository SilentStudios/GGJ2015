using UnityEngine;
using System.Collections;

public class RainBehaviour : Ambient {

	// Use this for initialization
	protected override void SetPathPrefab()
    {
 	    m_prefabToLoad = "Assets/Thelastofus/rain";
    }

}
