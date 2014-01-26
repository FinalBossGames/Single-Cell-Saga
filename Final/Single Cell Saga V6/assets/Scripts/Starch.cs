using UnityEngine;
using System.Collections;

public class Starch : MonoBehaviour {
	//Move bee
	GameObject target;
	public float time = 5;
	Vector3 position;
	//change bee
	public	Material on1;
	public	Material on2;
	public int dTimer =0;
	public int dest = 25;


	public GameObject thePlayer;

	// Use this for initialization
	void Start () 
	{   
		thePlayer = GameObject.Find ("PCube");

		//thePlayer.GetComponent<Lives>().AddPoint();



		target = gameObject;
		position = GameObject.Find("PCube").transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		iTween.MoveTo(target,position,time);
	}

	void OnTriggerStay (Collider other)//has the player hit a trigger
	{
		if (other.gameObject.name == "VC") {
			gameObject.renderer.material = on2;
			//destroy it
			dTimer++;
			if (dTimer>dest){
				Destroy(this.gameObject);
			thePlayer.GetComponent<Lives>().AddPoint();
			}
		}
	}


	void OnTriggerEnter (Collider other)//has the player hit a trigger
	{
//		if (other.gameObject.name == "VC") {
//			gameObject.renderer.material = on2;
//			//destroy it
//			dTimer++;
//			thePlayer.GetComponent<Lives>().AddPoint();
//		}

		if (other.gameObject.name == "PCube") 
		{		
			Destroy(this.gameObject);
		}
	}
	void OnTriggerExit (Collider other)//has the player hit a trigger
	{
		gameObject.renderer.material = on1;
		gameObject.rigidbody.detectCollisions = true;
	}
}
