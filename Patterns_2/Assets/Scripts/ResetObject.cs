using UnityEngine;
using System.Collections;


public class ResetObject : MonoBehaviour {

	public GameObject Left;
	public GameObject Middle;
	public GameObject Right;
	public GameObject RandomObject;
	public GameObject Train;

	void OnMouseDown(){
		Vector3 LeftOrigin = new Vector3 (22f, 2f, 0f);
		Vector3 MiddleOrigin = new Vector3 (28f, 2f, 0f);
		Vector3 RightOrigin = new Vector3 (34f, 2f, 0f);
		Vector3 RandomOrigin = new Vector3 (40f, 2f, 0f);
		Vector3 TrainOrigin = new Vector3 (0f, 0.24f , 5.46f);

		Left.transform.position = LeftOrigin;
		Middle.transform.position = MiddleOrigin;
		Right.transform.position = RightOrigin;
		RandomObject.transform.position = RandomOrigin;
		Train.transform.position = TrainOrigin;
	}
}
