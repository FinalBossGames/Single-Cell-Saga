using UnityEngine;
using System.Collections;
//Controls the player character
public class player : MonoBehaviour
{
	public int speed=5;
	void Start ()// Use this for initialization
	{}
	
	void Update ()// Update is called once per frame
	{
		move ();
	}

	void move ()//CHARACTER MOVEMENT
	{		
		//Turning
		if (Input.GetKey(KeyCode.RightArrow))//.GetKey(KeyCode.Joystick1Button1))
		{transform.Rotate(0,speed,0);}
		
		if (Input.GetKey(KeyCode.LeftArrow))
		{transform.Rotate(0,-speed,0);}
	}
}