using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHold : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		other.transform.parent = gameObject.transform;
	}

	void OnTriggerExit(Collider other) {
		other.transform.parent = null;
	}
}
