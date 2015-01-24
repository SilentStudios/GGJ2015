using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FigthTimeController : MonoBehaviour {

    void OnEnable()
    {
        EventServer.AddFightSuccessEvent += AddFigthSuccess;
    }

    private void AddFigthSuccess(float f)
    {
        Slider slider = GetComponent<Slider>();
        if (slider)
        {
            float newValue = slider.value + f;
            slider.value = Mathf.Clamp(newValue, 0, 1);
        }
            
    }
}
