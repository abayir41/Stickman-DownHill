using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHareket : MonoBehaviour {
	public float hiz1=-0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (hiz1,0, 0);
	}
}
