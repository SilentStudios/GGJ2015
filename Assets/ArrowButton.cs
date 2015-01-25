using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArrowButton : MonoBehaviour {

	public Sprite[] images;

	public void PushCorrect ()
	{
		GetComponent<Image> ().color = Color.green;
	}

	public void PushIncorrect ()
	{
		GetComponent<Image> ().color = Color.red;
	}

	public void changeSprite(KeyCode key) {
		switch (key) {
		case KeyCode.UpArrow:
			GetComponent<Image>().sprite = images[0];
			break;
		case KeyCode.RightArrow:
			GetComponent<Image>().sprite = images[1];
			break;
		case KeyCode.DownArrow:
			GetComponent<Image>().sprite = images[2];
			break;
		case KeyCode.LeftArrow:
			GetComponent<Image>().sprite = images[3];
			break;
		default:
			break;
		}
	}
}
