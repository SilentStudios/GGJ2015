using UnityEngine;
using System.Collections;

public abstract class Ambient : MonoBehaviour {

    protected string m_prefabToLoad;
    private GameObject m_prefab;

    void Awake()
    {
        SetPathPrefab();
    }

	// Use this for initialization
	void Start () {
        m_prefab = Resources.Load(m_prefabToLoad) as GameObject;
        if (m_prefab) m_prefab = Instantiate(m_prefab) as GameObject;
	}

    void OnDestroy()
    {
        Destroy(m_prefab);
    }

    protected abstract void SetPathPrefab();
}
