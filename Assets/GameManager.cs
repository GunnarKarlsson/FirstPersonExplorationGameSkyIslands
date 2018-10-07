using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject enemyOne;

	private List<GameObject> enemies;

	public static GameManager instance = null;

	//Public API

	public void startGame() {
		Debug.Log ("StartGame()");
		Debug.Log ("enemy count: " + enemies.Count);
		foreach(GameObject enemy in enemies)
		{
			enemy.SetActive (true);
		}

		Invoke ("enemiesStartShooting", 2.0f);
	}

	private void enemiesStartShooting() {
		foreach(GameObject enemy in enemies)
		{
			EnemyGunController enemyGun = enemy.transform.GetChild (0).GetComponent<EnemyGunController> () as EnemyGunController;
			enemyGun.StartShooting ();
		}
	}

	public void GameOver() {
		Debug.Log ("GameOver()");
		foreach(GameObject enemy in enemies)
		{
			EnemyGunController enemyGun = enemy.transform.GetChild (0).GetComponent<EnemyGunController> () as EnemyGunController;
			enemyGun.StopShooting ();
		}
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
		enemies = new List<GameObject> ();
		enemies.Add (enemyOne);
		startGame ();
	}

	// Update is called once per frame
	void Update () {
		
	}

}
