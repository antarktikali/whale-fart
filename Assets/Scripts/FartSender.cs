using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartSender : MonoBehaviour {
	public KeyCode fartKey = KeyCode.Space;
	public ObjectSpawner objectSpawner;
	public Animator animator;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (this.fartKey)) {
			this.objectSpawner.SpawnObject ();
			this.animator.Play ("tail_fart");
		}
	}
}
