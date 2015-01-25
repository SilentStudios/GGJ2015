using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StealthController : MonoBehaviour {

    public TimeSlider slider;
    public RandomButtosScript buttons;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (slider.isCompleted)
        {
            StartCoroutine("CheckSuccess");
            slider.Reset();
            buttons.Replay();
        }
	}

    IEnumerator CheckSuccess()
    {
        if (!buttons.isSuccess())
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAccionSigiloMalo",true);
            yield return new WaitForSeconds(0.5f);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetBool("isAccionSigiloMalo",false);
        }
    }
}
