using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	//Public API

	public void startGame() {
		Debug.Log ("StartGame()");
	}

	public void GameOver() {
		Debug.Log ("GameOver()");
	}

	//Private API

	void Awake()
	{
		Debug.Log ("Awake");
		//Check if instance already exists
		if (instance == null) {
			//if not, set instance to this
			instance = this;
			//If instance already exists and it's not this:
		} else if (instance != this) {
			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy (gameObject);    
		}
		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		startGame ();
	}

	// Update is called once per frame
	void Update () {
		
	}

}
