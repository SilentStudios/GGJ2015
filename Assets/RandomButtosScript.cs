﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomButtosScript : MonoBehaviour {

    public Image[] m_images;
    public Slider slider;
    public float ratioToAdd = 1;

	// Use this for initialization
	void Start () {
        m_images = GetComponentsInChildren<Image>();
        for (int i = 0; i < m_images.Length; ++i)
        {
            m_images[i].GetComponent<ButtonInput>().keyCode = InputManager.GetRandomKeyCode();
            //m_images[i].gameObject.name = m_images[i].GetComponent<ButtonInput>().keyCode.ToString();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (CheckIfAllButtonsArePushed())
        {
            slider.value += ratioToAdd * Time.deltaTime;
        }
	}

    private bool CheckIfAllButtonsArePushed()
    {
        bool toReturn = true;
        foreach (Image i in m_images)
        {
            if (!i.GetComponent<ButtonInput>().isPushed) return false;
        }
        return toReturn;
    }
}