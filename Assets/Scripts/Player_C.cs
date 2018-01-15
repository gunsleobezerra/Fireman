using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player_C : MonoBehaviour {
	
	public SpriteRenderer player_S;

	public Animator player_A;
	public float speed; 
	public Rigidbody2D player_F;
	public float forcejump;
	public RaycastHit2D ray;
	public GameObject bullet;
	public float dist;
	public int flag;
	GameObject bullet_clone;
	public GameObject wasborn;

	//UI
	public Text game_over;



	void Start () {
		

		player_A.SetFloat("Axis",0f);





	}
	

	void Update () {
		float axis_X = Input.GetAxis ("Horizontal");

		//Ray rast = new Ray (this.gameObject.transform.position, Vector3.down);
		Vector2 position = this.gameObject.transform.position;
		position.y += -1f; 
		RaycastHit2D rast1= Physics2D.Raycast(position,Vector2.down);

		/****Movimentação**********************************************************/
		//andar

		player_A.SetFloat ("Axis", axis_X);
		if (axis_X < 0){player_S.flipX = false; player_A.SetBool ("flipped", true);}
		else if(axis_X>0){player_S.flipX = true; player_A.SetBool ("flipped", false);}

		this.transform.Translate (axis_X*Time.deltaTime*speed, 0, 0, Space.Self);


		//pular

		if (rast1.distance>=0 && rast1.distance<=1) {
			player_A.SetBool ("Grounded", true);
			if (Input.GetKeyDown (KeyCode.Space)) {
				player_F.AddForce (Vector2.up * forcejump);
				flag += 1;
			}
			
			}else {
			player_A.SetBool ("Grounded", false);
			flag = 0;

		}

		dist = rast1.distance;
		Debug.DrawRay (new Vector3 (position.x, position.y, 0), Vector3.down,Color.green);



		//Atirar
		if (Input.GetKeyDown(KeyCode.Z)) {
			player_A.SetBool ("isFire", true);

			bullet_clone = Instantiate (bullet, this.gameObject.transform.position, Quaternion.identity) as GameObject;

			if (player_S.flipX == true) {
				bullet_clone.transform.name = "Right(bullet)";
			} else {
				bullet_clone.transform.name = "Left(bullet)";
			}



		} else {
			player_A.SetBool ("isFire", false);
		}
			

	}

	//Colisão
	void OnTriggerEnter2D(Collider2D col){
		GameObject HP;
		Count_life life;
		if (col.tag == "Dead" ) {
			kill ();


		}

		if (col.tag == "p_enemy" ) {
			HP = GameObject.FindWithTag ("HP");
			life = HP.gameObject.GetComponent<Count_life> ();
			life.life_hit ();

			if (life.life.GetInteger ("vida") == 0) {
				kill ();
			}

		}
	}

	//MORTE
	void kill(){
		GameObject HP ;
		Count_life life;
		HP = GameObject.FindWithTag("HP");


	
		if (wasborn != null) {
			
			wasborn = Instantiate (wasborn, wasborn.transform.position, wasborn.transform.rotation) as GameObject;

			life = HP.GetComponent<Count_life> ();

			life.life_hit ();

		} else {



		}



	
		Destroy (this.gameObject, 0.05f);
		//GAME OVER

	}

}
