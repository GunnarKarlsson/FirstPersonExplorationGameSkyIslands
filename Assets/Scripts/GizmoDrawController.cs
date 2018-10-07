using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDrawController : MonoBehaviour {

	public Transform platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (transform.position, platform.localScale);
	}
}
