using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceBox : MonoBehaviour {

	private bool humming;
	// Use this for initialization
	void Awake () {
		
	}

	public void Hum (bool hum) {
		this.humming = hum;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (humming) {
			Debug.Log("humming");
		} else {
			Debug.Log("silence");
		}

	}
}
