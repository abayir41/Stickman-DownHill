using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	public Vector2 yon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		yon = new Vector2 (Time.timeSinceLevelLoad * Hareket.hiz5 + 0.007f, 0);

		GetComponent<Renderer> ().material.mainTextureOffset = yon;
	}
}
