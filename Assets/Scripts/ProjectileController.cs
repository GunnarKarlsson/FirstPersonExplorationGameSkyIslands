using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {

	public float speed;
	public float lifeTime;
	public GameObject explosion;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("OnTriggerEnter");
		GameObject explosionInstance = Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
		Destroy(gameObject); 
		Destroy(explosionInstance, 0.5f); 
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("OnCollisionEnter");
	}
}
