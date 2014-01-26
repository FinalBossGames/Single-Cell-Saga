using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public double time;
	public GameObject Starch;
	Vector3 spawnLocation;
	public double delay = 10;
	public float min = 150;
	public float max = 250;
	public GameObject target;
	public float itime = 5;
	Vector3 position;


	void Start () {target = gameObject;
		spawnLocation = gameObject.transform.position;
		time = 0;
		position = target.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		time=  time+ 1;
		if (time>delay)
			spawnBee();
	}
	void spawnBee(){
		GameObject SpawnLocation = (GameObject)Instantiate(Starch, spawnLocation, Quaternion.identity);
		time=0;
		delay = Random.Range(min,max);
	}
}