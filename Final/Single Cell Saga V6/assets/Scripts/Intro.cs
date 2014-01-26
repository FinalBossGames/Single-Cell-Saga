using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	GameObject target;
	public float time = 5;
	Vector3 position;
	// Use this for initialization
	void Start () {
		target = gameObject;
		position = GameObject.Find("IntroTarget").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		iTween.MoveTo(target,position,time);
	}
}
