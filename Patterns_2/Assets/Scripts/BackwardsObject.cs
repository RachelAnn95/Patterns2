using UnityEngine;
using System.Collections;

public class BackwardsObject : MonoBehaviour {

	public float thrust;
	public GameObject train;

	Buttons BackwardsButton = new Buttons_Backwards();

	void OnMouseDown(){
		Vector3 Checkzero = new Vector3 (0f,0f,0f);
		if (!(train.GetComponent<Rigidbody> ().velocity == Checkzero)) {
			train.GetComponent<Rigidbody> ().velocity = Checkzero;
		}
		BackwardsButton.SphereClicked (train);

	}
}
