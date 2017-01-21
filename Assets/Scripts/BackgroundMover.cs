using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour {
	public float speed = -1.0f;
	public float resetAfter = -15.0f;

	private float counter = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float amount = this.speed * Time.deltaTime;
		this.counter += amount;
		this.gameObject.transform.Translate (new Vector3 (amount, 0.0f, 0.0f));
		if (this.counter <= this.resetAfter) {
			this.counter = 0.0f;
			this.gameObject.transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
		}
	}
}
