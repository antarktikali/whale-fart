using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRandomizer : MonoBehaviour {
	public Sprite[] sprite;

	public void AssignRandomSprite() {
		int index = Random.Range (0, this.sprite.Length);
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = this.sprite[index];
	}
}
