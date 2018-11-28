using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ParallaxScript : MonoBehaviour {
	public float amount;

	Camera cam;

	void Awake() {
		cam = GameObject.FindObjectOfType<Camera>();
	}

	void Update() {
		foreach (Transform child in transform) {
			child.position = new Vector3(
				cam.transform.position.x * child.position.z * amount,
				cam.transform.position.y * child.position.z * amount,
				child.position.z);
		}
	}
}
