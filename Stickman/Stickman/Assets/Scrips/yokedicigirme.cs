using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokedicigirme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D za){
		if(za.gameObject.tag == "yokedici"){
			Destroy(gameObject);
		}

	}

}
