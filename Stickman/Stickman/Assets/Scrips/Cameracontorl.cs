using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cameracontorl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Camerakaydir(){
		transform.localPosition = transform.position + new Vector3 (30f,0, 0);
			
	}
}
