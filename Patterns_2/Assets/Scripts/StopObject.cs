using UnityEngine;
using System.Collections;

public class StopObject : MonoBehaviour {

	public GameObject train;

	private Rigidbody rd;

	Buttons StopButton = new Buttons_Stop();

	void OnMouseDown(){
		StopButton.SphereClicked (train);

	}
}
