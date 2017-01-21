using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
	public GameObject sourceObject;
	public int bufferSize = 8;
	public float spawnFrequency = 2.0f;
	public bool manualSpawn = false;

	private float timeCounter = 0.0f;
	private ArrayList activeObjects = new ArrayList();
	private Stack inactiveObjects = new Stack();

	// Use this for initialization
	void Start () {
		for (int i = 0; i < this.bufferSize; i++) {
			GameObject spawnedObject = GameObject.Instantiate (this.sourceObject);
			spawnedObject.GetComponent<SpawnedObject> ().spawnedBy = this;
			spawnedObject.SetActive (false);
			this.inactiveObjects.Push (spawnedObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if (!this.manualSpawn) {
			this.timeCounter += Time.deltaTime;
			if (this.spawnFrequency <= this.timeCounter) {
				this.timeCounter = 0.0f;
				this.SpawnObject ();
			}
		}
	}

	public void SpawnObject() {
		GameObject spawnedObject;
		if (this.inactiveObjects.Count >= 1) {
			spawnedObject = this.inactiveObjects.Pop () as GameObject;
		} else {
			spawnedObject = GameObject.Instantiate (this.sourceObject);
			spawnedObject.GetComponent<SpawnedObject> ().spawnedBy = this;
		}
		spawnedObject.transform.position = this.gameObject.transform.position;
		spawnedObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
		SpriteRandomizer randomizer = spawnedObject.GetComponent<SpriteRandomizer> ();
		if (null != randomizer) {
			randomizer.AssignRandomSprite ();
		}
		spawnedObject.SetActive (true);
		this.activeObjects.Add (spawnedObject);
	}

	public void DeactivateObject( GameObject object_ ) {
		if (this.activeObjects.Contains (object_)) {
			this.activeObjects.Remove (object_);
			object_.SetActive (false);
			this.inactiveObjects.Push (object_);
		} else {
			Debug.LogError ("The object you're trying to deactivate was not in the active objects stack :O");
		}
	}
}
