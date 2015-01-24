using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeLeftChangeListener : MonoBehaviour {

    void OnEnable()
    {
        EventServer.AddTimeEvent += AddTime;
    }

    void OnDisable()
    {
        EventServer.AddTimeEvent -= AddTime;
    }

    private void AddTime(float f)
    {
        Slider slider = GetComponent<Slider>();
        if (slider)
            slider.value += f;
    }
}
