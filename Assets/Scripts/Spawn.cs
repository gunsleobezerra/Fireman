using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject Thing;
	GameObject object_old;
	public float brn_time;
	public string tag_thing;


	void Update () {

		 object_old = GameObject.FindWithTag (tag_thing);

		if (object_old == null) {
			object_old = Instantiate (Thing, transform.position, transform.rotation) as GameObject;

		}


		
	}
	

}
