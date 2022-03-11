using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_yuvarlm : MonoBehaviour {
	public float hiz1 = 1.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hiz1 = hiz1 + 0.0007f;
		GetComponent<Transform> ().Rotate (0, 0, hiz1);
	}
}
