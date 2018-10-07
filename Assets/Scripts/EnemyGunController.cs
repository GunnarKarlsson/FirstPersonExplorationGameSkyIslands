using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunController : MonoBehaviour {

	public GameObject theBullet = null;
	public AudioClip audioClip = null;

	private bool canShoot = false;

	public void StartShooting() {
		//canShoot = true;
		InvokeRepeating ("Shoot", Random.Range(2.0f, 5.0f), Random.Range(2.0f, 6.0f));
	}

	public void StopShooting() {
		//canShoot = false;
		CancelInvoke ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void Shoot() {
		//if (canShoot) {
		GameObject bullet = Instantiate (theBullet, transform.position, transform.rotation) as GameObject;
		AudioSource.PlayClipAtPoint (audioClip, transform.position);
		//}
	}
}
