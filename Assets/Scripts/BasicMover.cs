using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {
	public Vector3 direction;

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (this.direction * Time.deltaTime);
	}
}
