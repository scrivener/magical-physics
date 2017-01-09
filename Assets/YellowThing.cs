using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowThing : MonoBehaviour {

	public float yellowRepelFactor = 500.0f;
	public const float hearingDistance = 4.0f;
	private Rigidbody2D rigidbody2D;
	private GameObject player;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();	
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		VoiceBox vb = player.GetComponent<VoiceBox>();
		if (vb.IsHumming()) {
			float distanceToPlayer = (transform.position - player.transform.position).magnitude;
			if (distanceToPlayer < hearingDistance) {
				repelNearbyYellowThings();
			}
		}

	}

	void repelNearbyYellowThings() {
		Vector2 push = new Vector2();
		GameObject[] yellowThings = GameObject.FindGameObjectsWithTag("Yellow");
		foreach (GameObject crystal in yellowThings) {
			if (crystal == gameObject) {
				continue;
			}
			Vector2 directionToCrystal = crystal.transform.position - transform.position;
			float distanceToCrystal = directionToCrystal.magnitude;
			float inverseDistanceSquare = 1 / (distanceToCrystal * distanceToCrystal);
			push += directionToCrystal.normalized * yellowRepelFactor * inverseDistanceSquare;
		}
		rigidbody2D.AddForce(-push);
	}
}
