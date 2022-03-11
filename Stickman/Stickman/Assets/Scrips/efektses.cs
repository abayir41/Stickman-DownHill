using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class efektses : MonoBehaviour {
	public float Ses;
	public float Sesgorunum;
	// Use this for initialization
	void Start () {
		GetComponent<Slider> ().value = 1;
		GetComponent<Slider> ().value = PlayerPrefs.GetFloat ("Ses2");

	}

	// Update is called once per frame
	void Update () {

		Ses = GetComponent<Slider> ().value;
		Sesgorunum = Ses;
		PlayerPrefs.SetFloat ("Ses2", Ses);
	}
}
