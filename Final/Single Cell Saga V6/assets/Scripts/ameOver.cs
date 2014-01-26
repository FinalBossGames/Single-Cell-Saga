using UnityEngine;
using System.Collections;

public class ameOver : MonoBehaviour {
	private GUIText score;
	private GUIText highScore;
	// Use this for initialization
	void Start () {
		score = GameObject.Find ("High").guiText;
		score.text = "High Score: " + PlayerPrefs.GetInt ("highscore").ToString ();
		//GUI TEXT LIVES
		highScore = GameObject.Find ("Yours").guiText;
		highScore.text = "Your Score: " + PlayerPrefs.GetInt ("currentscore").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Menu");			
		}
	}
}
