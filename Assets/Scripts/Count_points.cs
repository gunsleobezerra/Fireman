using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Count_points : MonoBehaviour {
	public Text points;
	int POINTS;
	public int point1,point2,point;
	void Start () {
		
	}
	
	public void set_point(string tag){

		switch (tag) {

		case "enemy":

			POINTS += point;

		break;

		case "enemy1":

			POINTS += point1;
			break;

		case "enemy2":

			POINTS += point2;
			
			break;


		}

		points.text = POINTS.ToString ();
	}

}
