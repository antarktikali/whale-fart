using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {
	public float timeLeft = 60.0f;
	public GUIText guiText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.timeLeft -= Time.deltaTime;
		this.guiText.text = "Time left: " + (int) this.timeLeft;
		if (this.timeLeft <= 0.0f) {
			SceneManager.LoadScene ("credits");
		}
	}
}
