using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Rotate : MonoBehaviour
	{
		public float speed = 10f;
		public AudioSource source;

	void Update ()
	{
			transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider other)
	{
		source.Play();       
		Destroy (gameObject);
	}
}

