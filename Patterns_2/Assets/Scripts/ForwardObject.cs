using UnityEngine;
using System.Collections;

public class ForwardObject : MonoBehaviour {

	public float thrust;
	public GameObject train;

	Buttons ForwardsButton = new Buttons_Forwards();

	void OnMouseDown(){
		Vector3 Checkzero = new Vector3 (0f,0f,0f);
		if (!(train.GetComponent<Rigidbody> ().velocity == Checkzero)) {
			train.GetComponent<Rigidbody> ().velocity = Checkzero;
		}
		ForwardsButton.SphereClicked (train);

	}
}
