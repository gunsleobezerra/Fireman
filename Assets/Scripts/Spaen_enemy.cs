using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class Spaen_enemy : MonoBehaviour {

	public GameObject Thing,Thing2,Thing3,Thing4;
	GameObject object_old;
	public float time_seconds;
	int rand2;
	float time_count;
	int enemy_count=0,rating=10;
	void Update(){



		if (enemy_count == rating) {
			time_seconds -= 0.1f;
			rating += 10;
		}
		time_count += Time.deltaTime;
		if (time_count > time_seconds) {
			enemy_count += 1;
			Spawn_machine ();
			time_count = 0;
		}
		//Debug.Log (time_count.ToString ());
		Debug.Log(time_seconds.ToString());
	}


	void Start(){
		


		object_old = Instantiate (Thing, transform.position, transform.rotation) as GameObject;
		time_count = 0;

	}
	public void Spawn_machine () {
		


			rand2 = Random.Range (1, 4);
			spawn_this (rand2);
	



	}

	void spawn_this(int code){

		switch (code){

		case 1:

			if (Thing != null) {
				object_old = Instantiate (Thing, transform.position, transform.rotation) as GameObject;
			} else if(object_old!=null) {

				object_old = Instantiate (object_old, transform.position, transform.rotation) as GameObject;

			}

		break;


		case 2:

			if (Thing2 != null) {
				object_old = Instantiate (Thing2, transform.position, transform.rotation) as GameObject;
			} else if(object_old!=null) {

				object_old = Instantiate (object_old, transform.position, transform.rotation) as GameObject;

			}


			break;

		case 3:

			if (Thing3 != null) {
				object_old = Instantiate (Thing3, transform.position, transform.rotation) as GameObject;
			} else if(object_old!=null){

				object_old = Instantiate (object_old, transform.position, transform.rotation) as GameObject;

			}


			break;

		case 4:

			if (Thing4 != null) {
				object_old = Instantiate (Thing4, transform.position, transform.rotation) as GameObject;
			} else if(object_old!=null){

				object_old = Instantiate (object_old, transform.position, transform.rotation) as GameObject;

			}


		break;

		


		}



}





}
