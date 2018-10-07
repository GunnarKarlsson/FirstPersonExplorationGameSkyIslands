using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	public Transform platform;
	public Transform pos1;
	public Transform pos2;
	public Vector3 newPos;
	public string currState;
	public float smooth = 10f;
	public float resetTime = 7f;
	public string STATE_ONE = "state_one";
	public string STATE_TWO = "state_two";

	void Start() {
		ChangeTarget ();
	}

	void FixedUpdate() {
		platform.position = Vector3.Lerp (platform.position, newPos, smooth * Time.deltaTime);
	}

	void ChangeTarget() {
		if (currState == STATE_ONE) {
			currState = STATE_TWO;
			newPos = pos2.position;
		} else if (currState == STATE_TWO) {
			currState = STATE_ONE;
			newPos = pos1.position;
		} else if (currState == "") {
			currState = STATE_TWO;
			newPos = pos2.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}