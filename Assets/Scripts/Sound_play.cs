using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_play : MonoBehaviour {

	public AudioSource Player_sound;
	public AudioClip a1;
	public int sound;

	void Start () {

		Player_sound.clip = a1;
		Player_sound.Play();

	}
	

	void Update () {
		
	}
}
