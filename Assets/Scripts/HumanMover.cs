using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMover : MonoBehaviour {
	public float walkingSpeedMin = 0.2f;
	public float walkingSpeedMax = 0.6f;
	public Vector3 axis;

	private int walkingDirection = 1;
	private float walkingSpeed;

	void OnEnable () {
		this.walkingSpeed = Random.Range (this.walkingSpeedMin, this.walkingSpeedMax);
		this.walkingDirection = ( Random.Range (0, 2) > 0 ) ? -1 : 1;
		this.gameObject.transform.localScale = new Vector3 (
			// *-1, otherwhise they do m00nwalk ;P
			Mathf.Abs(gameObject.transform.localScale.x) * this.walkingDirection * -1.0f,
			this.gameObject.transform.localScale.y,
			this.gameObject.transform.localScale.z
		);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (
			this.axis.normalized * this.walkingDirection * this.walkingSpeed * Time.deltaTime
		);
	}
}
