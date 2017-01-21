using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCollapse : MonoBehaviour {
	public ObjectSpawner fartSpawner;
	public ObjectSpawner humanSpawner;
	public string FART_TAG = "fart";
	public string HUMAN_TAG = "human";
	public AudioSource audioSource;

	private bool isFalling = false;

	void OnEnable() {
		this.isFalling = false;
	}

	//void OnTriggerEnter2D (Collider2D other_ ){
	void OnTriggerStay2D (Collider2D other_ ){
	if (other_.CompareTag (this.FART_TAG)) {
			// Remove the fart
			other_.gameObject.GetComponent<SpawnedObject>().spawnedBy.DeactivateObject( other_.gameObject );
			Debug.Log ("make the building fall");
			this.audioSource.Play ();
			GameObject.Find ("score").GetComponent<ScoreHandler> ().score -= 5;
			this.isFalling = true;
			this.gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		} else if (other_.CompareTag (this.HUMAN_TAG) && this.isFalling) {
			Debug.Log ("destroy human!");
			GameObject.Find ("score").GetComponent<ScoreHandler> ().score += 5;
			other_.gameObject.GetComponent<SpawnedObject>().spawnedBy.DeactivateObject( other_.gameObject );
		}
	}
}
