using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket3 : MonoBehaviour {
	public float hiz1=-0.005f;
	public static float hiz2;
	// Use this for initialization
	void Start () {
		hiz2 = 0.00005f;
		transform.Rotate (0, 0, -30);
		transform.localPosition = transform.position + new Vector3 (0, 0.15f, 0);
	}

	// Update is called once per frame
	void Update () {
		hiz1 = hiz1 - hiz2;
		transform.Translate (hiz1 * Hareket.Durdurmakont,0, 0);

	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "yokedici"){
			Destroy(gameObject);
		}

	}
}
