using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour {

	public Transform origin;
	public Transform destination;

	//private Player playerScript;
	//private Scroll scroll;
	private CameraScroll cScroll;



	void Start() {
		
		//playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		//scroll = GameObject.Find("Level").GetComponent<Scroll>();
		cScroll = Camera.main.GetComponent<CameraScroll>();
	}



	void OnCollisionEnter (Collision coll) {

		if (coll.gameObject.tag == "Player") {
			coll.transform.position = destination.position;
			//playerScript.speedBoost = 5f;
			cScroll.speedBoost = 5f;
			//scroll.speedBoost = 0;
		}
	}
}
