using UnityEngine;
using System.Collections;

public class RandomObject : MonoBehaviour {

	public GameObject Left;
	public GameObject Middle;
	public GameObject Right;

	private ArrayList numberOrder = new ArrayList ();
	private ArrayList MyObjects = new ArrayList ();

	void OnMouseDown(){
		Vector3 OnePosition = Left.transform.position;
		Vector3 TwoPosition = Middle.transform.position;
		Vector3 ThreePosition = Right.transform.position;

		int RanNum = Random.Range (0, 3);
		numberOrder.Add(RanNum);

		int RanNum2 = Random.Range (0, 3);
		while (RanNum == RanNum2) {
			RanNum2 = Random.Range (0, 3);
		}
		numberOrder.Add (RanNum2);

		int RanNum3 = Random.Range (0, 3);
		while (RanNum3 == RanNum || RanNum3 == RanNum2) {
			RanNum3 = Random.Range (0, 3);
		}
		numberOrder.Add(RanNum3);

		MyObjects.Add (Left);
		MyObjects.Add (Middle);
		MyObjects.Add (Right);

		for (int i = 0; i < 3; i++) {
			GameObject NewSphere = (GameObject)MyObjects [i];
			int num = (int)numberOrder [i];
			if (num == 0) {
				NewSphere.transform.position = OnePosition;
			}
			if (num == 1) {
				NewSphere.transform.position = TwoPosition;
			}
			if (num == 2) {
				NewSphere.transform.position = ThreePosition;
			}
				
		}
	
	}
}
