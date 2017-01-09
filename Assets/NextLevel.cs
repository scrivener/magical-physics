using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		SceneManager.LoadScene ("TestLevels/PlatformingTest");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
