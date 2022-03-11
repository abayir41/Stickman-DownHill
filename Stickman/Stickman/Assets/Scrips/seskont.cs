using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskont : MonoBehaviour {
	public float Ses;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Ses = PlayerPrefs.GetFloat ("Ses2");
		GetComponent<AudioSource> ().volume = Ses;
	}
}
