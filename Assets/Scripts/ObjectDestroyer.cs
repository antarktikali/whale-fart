using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {
	public ObjectSpawner objectSpawner;

	void OnTriggerEnter2D (Collider2D other_ ){
		objectSpawner.DeactivateObject (other_.gameObject);
	}
}
