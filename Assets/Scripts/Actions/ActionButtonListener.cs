using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActionButtonListener : MonoBehaviour {

    public ActionType type;
    public enum ActionType
    {
        DANCE = 0,
        STEALTH,
        CRY,
        FIGHT
    }

    void OnEnable()
    {
        EventServer.ChangeActionEvent += ChangeEvent;
        GetComponent<Image>().color = Color.grey;
    }

    void OnDisable()
    {
        EventServer.ChangeActionEvent -= ChangeEvent;
    }

    private void ChangeEvent(ActionActor ambient)
    {
        bool same = false;
        switch (type)
        {
            case ActionType.DANCE:
                if (ambient.GetType() == typeof(DanceActionActor))
                    same = true;
                break;

            case ActionType.STEALTH:
                if (ambient.GetType() == typeof(StealthActionActor))
                    same = true;
                break;

            case ActionType.CRY:
                if (ambient.GetType() == typeof(CryActionActor))
                    same = true;
                break;

            case ActionType.FIGHT:
                if (ambient.GetType() == typeof(FightActionActor))
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
