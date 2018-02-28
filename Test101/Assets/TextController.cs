using UnityEngine;
using UnityEngine.UI; //To access Text object
using System.Collections;

public class TextController : MonoBehaviour {
	
	//Provides access to the Text object
	public Text text;
	
	// Use this for initialization
	void Start () {
		text.text = "Hello World";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
