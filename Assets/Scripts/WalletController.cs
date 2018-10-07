using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalletController : MonoBehaviour {

	public int coinCount = 0;
	public Text coinsText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addOneCoin() {
		coinCount++;
		coinsText.text = "Coins: " + coinCount;
	}
}