using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmbientButtonListener : MonoBehaviour {

    public AmbientType type;
    public enum AmbientType
    {
        RAIN = 0,
        STORM,
        DARKNESS,
        PARTY
    }

    void Start()
    {
        EventServer.ChangeAmbientEvent += ChangeEvent;
    }
    void OnDisable()
    {
        EventServer.ChangeAmbientEvent -= ChangeEvent;
    }

    void OnEnable()
    {
        
        GetComponent<Image>().color = Color.grey;
    }

    private void ChangeEvent(Ambient ambient)
    {
        bool same = false;
        switch (type)
        {
            case AmbientType.DARKNESS:
                if (ambient.GetType() == typeof(DarknessBehaviour))
                    same = true;
                break;

            case AmbientType.PARTY:
                if (ambient.GetType() == typeof(BalloonBehaviour))
                    same = true;
                break;

            case AmbientType.RAIN:
                if (ambient.GetType() == typeof(RainBehaviour))
                    same = true;
                break;

            case AmbientType.STORM:
                if (ambient.GetType() == typeof(StormBehaviour))
                    same = true;
                break;

            default:
                break;
        }

        if (same)
            GetComponent<Image>().color = Color.white;
        else
            GetComponent<Image>().color = Color.grey;
    }

}
