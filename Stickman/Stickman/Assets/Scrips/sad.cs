using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sad : MonoBehaviour {
	public float hiz1;
	public float hiz2;
	// Use this for initialization
	void Start () {
		transform.localPosition = transform.position + new Vector3(0,2,0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (hiz1,hiz2, 0);
	}
}
