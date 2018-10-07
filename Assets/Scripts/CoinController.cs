using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	public float speed = 10f;
	public GameObject audioManager;
	public GameObject wallet;

	private AudioController audioController;
	private WalletController walletController;

	void Start() {
		audioController = (AudioController) audioManager.GetComponent<AudioController> ();
		walletController = (WalletController)wallet.GetComponent<WalletController> ();
	}

	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider other)
	{
		if (audioController != null) {
			audioController.playCoinSound ();
		}

		if (walletController != null) {
			walletController.addOneCoin ();
		}

		Destroy (gameObject);
	}
}
