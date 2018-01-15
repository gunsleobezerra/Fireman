using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_life : MonoBehaviour {
	public float speed;

	public SpriteRenderer player_S;

	public float bullet_time;

	Vector2 direction = new Vector2(1,0);

	void Start(){
		if (this.transform.name =="Left(bullet)") {
			direction *= -1; 
			player_S.flipX = true;
		} else {
			
			player_S.flipX = false;
		}
	}


	void Update () {
			

		this.gameObject.transform.Translate (direction* Time.deltaTime * speed*this.transform.localScale.x, Space.Self);
			

			
		Destroy (this.gameObject, bullet_time);
		
	}


	void OnTriggerEnter2D(Collider2D bullet){

		if (bullet.tag == "enemy" || (bullet.tag == "enemy1") || (bullet.tag == "enemy2")) {

			this.enabled = false;
			DestroyObject (this.gameObject);
		} else {

			DestroyImmediate (this.gameObject);

		}


	}
}
