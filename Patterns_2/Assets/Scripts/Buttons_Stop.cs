using UnityEngine;
using System.Collections;

[System.Serializable]
public class Buttons_Stop : Buttons {

	private Rigidbody rd;

	public override void SphereClicked (GameObject o) { 
		rd = o.GetComponent<Rigidbody> ();
		rd.velocity = Vector3.zero;
	}
}
