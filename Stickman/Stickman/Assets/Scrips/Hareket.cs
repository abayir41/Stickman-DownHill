using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour {
	public float hiz1=-0.05f;
	public static float hiz5;
	public static float hiz2;
	public static float Durdurmakont;
	// Use this for initialization
	void Start () {
		Durdurmakont = 1;
		hiz2 = 0.00007f;
	}
	
	// Update is called once per frame
	void Update () {
		hiz5 = hiz1 * -1;
		hiz1 = hiz1 - hiz2;
		transform.Translate (hiz1 * Durdurmakont,0, 0);

	}
}
