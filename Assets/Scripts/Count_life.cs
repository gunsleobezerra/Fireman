using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class Count_life : MonoBehaviour {
	public Animator life;
	int count;
	Scene THIS;
	public Text GAME_OVER;
	float time=0;
	GameObject player;



	void Update(){

		if (GAME_OVER.enabled) {
			player = GameObject.FindWithTag ("Player");
			if(player!=null) DestroyImmediate (player);
			time += Time.deltaTime;
			if (time > 4f) {
				
			
				GAME_OVER.enabled = false;
				THIS = SceneManager.GetActiveScene ();
				SceneManager.LoadScene (THIS.name);

			}
		}


	}

	public void life_hit(){
		GAME_OVER.enabled = false;
		count = life.GetInteger ("vida");
		count--;
		if (count != 0) {
			
			life.SetInteger ("vida", count);
		} else {



				GAME_OVER.enabled = true;
			time = 0f;






		}

	}


}
