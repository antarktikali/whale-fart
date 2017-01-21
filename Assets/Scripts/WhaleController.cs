using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleController : MonoBehaviour {
	public float max = 6.5f;
	public float min = -6.5f;
	public KeyCode left = KeyCode.A;
	public KeyCode right = KeyCode.D;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (this.left)) {
			float amount = this.speed * -1.0f * Time.deltaTime;
			if (this.gameObject.transform.position.x + amount > this.min) {
				this.gameObject.transform.Translate (new Vector3 (amount, 0.0f, 0.0f));
			}
					
		}
		if (Input.GetKey (this.right)) {
			float amount = this.speed * Time.deltaTime;
			if (this.gameObject.transform.position.x + amount < this.max) {
				this.gameObject.transform.Translate (new Vector3 (amount, 0.0f, 0.0f));
			}
		}
	}
}
