using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate (0, 0, -30);
		transform.localPosition = transform.position + new Vector3 (0, 1.8f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D col){
		if(col.gameObject.tag == "yokedici"){
			Destroy(gameObject);
		}

	}
}
