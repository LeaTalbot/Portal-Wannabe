using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {



	public float speedBoost = 5;


	void Update () {

		this.gameObject.transform.Translate(Vector3.down * Time.deltaTime * speedBoost);
	}
}
