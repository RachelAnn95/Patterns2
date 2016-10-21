﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Buttons_Backwards : Buttons {

	private Rigidbody rd;

	public override void SphereClicked (GameObject o) { 
		rd = o.GetComponent<Rigidbody> ();
		Vector3 movement = o.transform.right;
		rd.AddForce (movement * 30 * -1f);
	}
}
