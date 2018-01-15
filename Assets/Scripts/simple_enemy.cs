using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine;

public class simple_enemy : MonoBehaviour {

	public int H_enemy;
	public int enemy_speed;

	public Animator enemy;
	public int enemy_rate;
	float direct=1;
	 GameObject points;
	float time_count =0;


	void Start () {

		enemy = this.gameObject.GetComponent<Animator> ();

		points = GameObject.FindWithTag ("point");





	}
	

	void Update () {
	

		this.gameObject.transform.Translate (direct*Vector2.left*enemy_speed*Time.deltaTime, Space.Self);
		time_count += Time.deltaTime;

		if (time_count > 20f) kill_me (0);
			

	}

	//teste de colisão
	void OnTriggerEnter2D(Collider2D bullet){
		SpriteRenderer enemy;
		enemy = this.gameObject.GetComponent<SpriteRenderer> ();
		switch(bullet.tag){

		case "Bullet":
			
			H_enemy--;

			if (H_enemy == 0) {
				kill_me (1);

			
			}
				break;

		case "end":
		case "p_enemy":
			direct *= -1;
			if (direct == -1) {
				enemy.flipX = false;

			} else {
				enemy.flipX = true;
			}

			//kill_me ();
		break;

		case "Dead":

			kill_me (0);

			break;



		}


	}

	void kill_me(int mode){
		Count_points P;

		if (mode == 1) {
			P = points.GetComponent<Count_points> ();

			P.set_point (this.tag);
		}

		enemy_speed = 0;
		 float time_dead = 0.5f;
		enemy.SetBool ("isdead", true);
		Destroy(this.gameObject,time_dead);

	}



}
