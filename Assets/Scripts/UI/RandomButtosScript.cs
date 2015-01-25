using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomButtosScript : MonoBehaviour {

    public Image[] m_images;
    public Slider slider;
    public float ratioToAdd = 1;

    public bool isSuccess()
    {
        foreach (Image i in m_images)
        {
            if (i.gameObject.activeSelf)
                return false;
        }
        return true;
    }

	// Use this for initialization
	void Start () {
        if (m_images == null)
            m_images = GetComponentsInChildren<Image>();
        for (int i = 0; i < m_images.Length; ++i)
        {
            m_images[i].gameObject.SetActive(true);
            m_images[i].GetComponent<ButtonInput>().keyCode = InputManager.GetRandomKeyCode();
            //m_images[i].gameObject.name = m_images[i].GetComponent<ButtonInput>().keyCode.ToString();
        }
	}



    internal void Replay()
    {
        Start();
    }
}
