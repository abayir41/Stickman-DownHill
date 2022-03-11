using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egilme : MonoBehaviour {
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Transform> ().Rotate (0, 0, 90);
		}
	
		if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<Transform> ().Rotate (0, 0, -90);
		}
	
	}

}

