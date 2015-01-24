using UnityEngine;
using System.Collections;

public class TextureOffset : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        renderer.material.mainTextureOffset = new Vector2(renderer.material.mainTextureOffset.x + Time.deltaTime*speed, 0.0f);
	}
}
