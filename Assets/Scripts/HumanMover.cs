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
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (
			this.axis.normalized * this.walkingDirection * this.walkingSpeed * Time.deltaTime
		);
	}
}
