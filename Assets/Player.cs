using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {



	Rigidbody myBody; 

	public float playerSpeed = 5;

	public float currentXSpeed;
	public float currentYSpeed;
	//public float speedBoost = 5;





	void Start () {

		myBody = GetComponent<Rigidbody>();
		myBody.velocity = new Vector2(0, 0);
	}
	



	void Update () {
	

		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			currentXSpeed = -playerSpeed;
		}
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
			currentXSpeed = playerSpeed;
		}
		if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
			currentYSpeed = -playerSpeed;
		}
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
			currentYSpeed = playerSpeed;
		}


		//release the keys 
		if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow)) {
			if (currentXSpeed < 0) {
				currentXSpeed = 0;
			}
		}
		if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)) {
			if (currentXSpeed > 0) {
				currentXSpeed = 0;
			}
		}
		if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)) {
			if (currentYSpeed < 0) {
				currentYSpeed = 0;
			}
		}
		if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)) {
			if (currentYSpeed > 0) {
				currentYSpeed = 0;
			}
		}
			
		//actually moving:
		myBody.velocity = new Vector2(currentXSpeed, currentYSpeed);
	}
}
