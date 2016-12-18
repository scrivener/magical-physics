using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceBox : MonoBehaviour {

	private bool humming;
	AudioSource voiceSource;

	// Use this for initialization
	void Awake () {
		voiceSource = GetComponent<AudioSource>();
	}

	public void Hum (bool hum) {
		if (humming && !hum) {
			voiceSource.Stop();
		}
		if (!humming && hum) {
			voiceSource.Play();
		}
		humming = hum;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}
}
