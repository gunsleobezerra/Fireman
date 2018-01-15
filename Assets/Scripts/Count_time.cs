using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Count_time : MonoBehaviour {

	Text time;
	public Text time2;

	float TIME_COUNT=0,TIME_COUNT2=0;
	int TIME;

	void Start () {
		time = this.gameObject.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (TIME != 59) {
			TIME_COUNT += Time.deltaTime;
			TIME = (int)TIME_COUNT;
			time.text = TIME.ToString ();
		} else {

			TIME = 0;
			TIME_COUNT = 0;
			TIME_COUNT2++;

			time2.text = TIME_COUNT2.ToString () + " : ";


		}
	}
}
