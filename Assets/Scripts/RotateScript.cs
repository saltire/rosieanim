using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
	public float rotateAngle = 10;
	public float speed = 1;
	public Vector2 pivot;

	Vector2 pivotUnits;

	void Start() {
		Bounds bounds = GetComponent<SpriteRenderer>().sprite.bounds;
		pivotUnits = new Vector3(pivot.x * bounds.size.x, pivot.y * bounds.size.y) - bounds.extents;
	}

	void Update() {
		float angle = Mathf.Sin(Time.time * speed) * rotateAngle;
		Vector3 point = transform.TransformPoint(pivotUnits);
		transform.RotateAround(point, Vector3.forward, angle - transform.localEulerAngles.z);
	}
}
