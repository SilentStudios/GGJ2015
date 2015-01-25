using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    public Image background;
    public Sprite[] images;

    public Button exit;
    public Button start;

    int index = 0;

    void Start()
    {
        index = 0;
    }

    public void NextImage()
    {
        //exit.gameObject.SetActive(false);
        
        if (index < images.Length)
        {
            background.sprite = images[index];
			index++;
        }
        else
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        Application.LoadLevel("mainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
