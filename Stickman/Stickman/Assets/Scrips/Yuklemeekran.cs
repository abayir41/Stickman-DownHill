using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yuklemeekran : MonoBehaviour {
	public static float yukleme;
	public Slider slider;
	public GameObject Yuklmeekrani;
	// Use this for initialization
	void Start () {
		Yuklmeekrani.SetActive (false);
		yukleme = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(yukleme > 0){
			Yuklmeekrani.SetActive (true);
		}
		slider.GetComponent<Slider> ().value = yukleme;
	}
}
