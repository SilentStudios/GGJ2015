using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

    public void StartGame()
    {
        Application.LoadLevel("mainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
