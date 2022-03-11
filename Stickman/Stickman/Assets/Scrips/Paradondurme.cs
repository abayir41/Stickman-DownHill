using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paradondurme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().Rotate (0, 1, 0);
	}
	void OnCollisionEnter2D(Collision2D para){
		if (para.gameObject.tag == "karakter") {
			Destroy (gameObject);
		}
		if(para.gameObject.tag == "yokedici"){
			Destroy(gameObject);
	
	}


}
}