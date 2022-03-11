using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket2 : MonoBehaviour {
	public float hiz2 = 0.05f;
	public static float hiz1 = 0.00007f;
	// Use this for initialization
	void Start () {
		hiz1 = 0.00007f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,hiz2 * Hareket.Durdurmakont, 0);
		hiz2 = hiz2 + hiz1;
	}
}
