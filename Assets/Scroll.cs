using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {



	public float speedBoost = 0;

	void Update () {

		this.gameObject.transform.Translate(Vector3.up * Time.deltaTime * (5 + speedBoost));
	}
}