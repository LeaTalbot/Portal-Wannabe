using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portaling : MonoBehaviour {



	private GameObject player;
	private GameObject mousePos;
	private GameObject origin;
	private GameObject destination;
	private Player playerScript;
	//private Scroll scroll;
	private CameraScroll cScroll;





	void Start () {
		player = this.gameObject;
		//playerScript = player.GetComponent<Player>();
		//scroll = GameObject.Find("Level").GetComponent<Scroll>();
		cScroll = Camera.main.GetComponent<CameraScroll>();
		mousePos = GameObject.FindGameObjectWithTag("Mouse");
		origin = GameObject.FindGameObjectWithTag("Origin");
		destination = GameObject.FindGameObjectWithTag("Destination");
	}




	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			RaycastPlayerDown();
			//playerScript.speedBoost = 10f;
			cScroll.speedBoost = 20f;
			//scroll.speedBoost = 10f;
			RaycastMouseUp();
		}
	}


	void RaycastPlayerDown() {

		RaycastHit firstObjectHit;
		Vector3 rayDown = player.transform.TransformDirection(Vector3.down);
		Debug.DrawRay(player.transform.position, rayDown * 50, Color.green);

		if (Physics.Raycast(player.transform.position, rayDown, out firstObjectHit, 50)) {
			if (firstObjectHit.collider.tag == "Wall") {
				//get collision point
				origin.transform.position = firstObjectHit.point;
			} else {
				return;
			}
		}
	}

	void RaycastMouseUp() {

		mousePos.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20)); //20 = distance from camera (which is at -10) and not the coordinates

		RaycastHit secondObjectHit;
		Vector3 rayUp = mousePos.transform.TransformDirection(Vector3.up);
		Debug.DrawRay(mousePos.transform.position, rayUp * 50, Color.red);

		if (Physics.Raycast(mousePos.transform.position, rayUp, out secondObjectHit, 50)) {
			if (secondObjectHit.collider.tag == "Wall") {
				destination.transform.position = secondObjectHit.point;
			} else {
				return;
			}
		}
	}
}
