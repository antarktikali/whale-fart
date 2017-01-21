using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartSender : MonoBehaviour {
	public KeyCode fartKey = KeyCode.Space;
	public ObjectSpawner objectSpawner;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (this.fartKey)) {
			this.objectSpawner.SpawnObject ();
		}
	}
}
