using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contro_Mobile : MonoBehaviour {

	public void fired(){
		GameObject player;

		player = GameObject.FindGameObjectWithTag ("Player"); 
		Player_C contro_S;
		contro_S = player.GetComponent<Player_C>();
		contro_S.fired = 1;
	}

	public void jump(){
		GameObject player;
		player = GameObject.FindGameObjectWithTag ("Player"); 
		Player_C contro_S;
		contro_S = player.GetComponent<Player_C>();
		contro_S.jumpi = 1;
	}
	
	public void Move(int direction){
		GameObject player;

		player = GameObject.FindGameObjectWithTag ("Player"); 
		Player_C contro_S;

		contro_S = player.GetComponent<Player_C>();


		switch (direction) {

		case 1:

			contro_S.direct = 1;

			break;

		case 2:


			contro_S.direct = -1;

		break;

		default:

			contro_S.direct = 0;

		break;


		}


	}
}
