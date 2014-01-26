using UnityEngine;
using System.Collections;

public class MenuClick : MonoBehaviour {
	bool level1;
	bool help;
	
	// Use this for initialization
	void Start ()
	{
		level1 = false;
		help = false;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		if (level1 == true)
			Application.LoadLevel("Level 1");
		if (help == true)
			Application.LoadLevel("Tutorial");
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit();
	}
	
	void OnMouseDown ()
	{
		if(gameObject.name == "Start")
			level1 = true;
		if(gameObject.name == "Tutorial")
		help = true;
	}	
}
