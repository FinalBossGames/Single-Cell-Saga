using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public bool dead = false;
	public int health = 20;
	public int points = 0;
	public	Material on1;
	public AudioClip otherClip1;
	public AudioClip otherClip2;
	private GUIText textLives;
	private GUIText textPoints;

	void Start ()// Use this for initialization
	{
//		otherClip1 = Resources.Load ("Damage_Splat") as  AudioClip;
//		audio.clip = otherClip1;	
//		otherClip2 = Resources.Load ("Absorb_Splat") as  AudioClip;
//		audio.clip = otherClip2;
	}
	
	void Update ()// Update is called once per frame
	{

		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel ("Menu");			
		}



		textPoints = GameObject.Find ("Score").guiText;
		textPoints.text = "Points: " + points.ToString ();
		//GUI TEXT LIVES
		textLives = GameObject.Find ("Health").guiText;
		textLives.text = "Health: " + health.ToString ();
		if (dead == true) {
			health--;			
			if (health > -1) {
				dead = false;
			} else {
				if (points > PlayerPrefs.GetInt ("highscore")) {
					PlayerPrefs.SetInt ("highscore", points);

				}
				PlayerPrefs.SetInt ("currentscore", points);
				Application.LoadLevel ("GameOver");	
			}
		}

	}

	public void AddPoint(){points++;}


	void OnTriggerEnter (Collider other)//has the player hit a trigger
	{
		if (other.gameObject.name == "Starch(Clone)") 
		{	
			if(other.gameObject.renderer.sharedMaterial == on1){
				dead=true; 
				audio.PlayOneShot (otherClip1);
			}else{
				AddPoint();
				audio.PlayOneShot (otherClip2);
			}
		}
	}
}
