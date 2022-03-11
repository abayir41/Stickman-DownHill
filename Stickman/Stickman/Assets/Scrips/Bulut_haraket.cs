using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulut_haraket : MonoBehaviour {
	public float hiz1=-0.03f;
	// Use this for initialization
	void Start () {
		transform.Rotate (0, 0, -15);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (hiz1 * Hareket.Durdurmakont ,0.002f * Hareket.Durdurmakont, 0);
	}
	void OnCollisionEnter2D (Collision2D bulut){
		if(bulut.gameObject.tag == "yokedici"){
			Destroy(gameObject);
		}

	}
}
