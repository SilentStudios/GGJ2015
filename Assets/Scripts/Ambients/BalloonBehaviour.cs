using UnityEngine;
using System.Collections;

public class BalloonBehaviour : Ambient
{
    // Use this for initialization
    protected override void SetPathPrefab()
    {
        m_prefabToLoad = "Prefabs/Background/BackgroundParty";
    }
}