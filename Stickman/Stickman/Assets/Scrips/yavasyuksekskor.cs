using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yavasyuksekskor : MonoBehaviour {
	public Text yyuskeskor,skore,yskor;
	public float yskore,yyuksekskore;
	// Use this for initialization
	void Start () {
		yyuksekskore = PlayerPrefs.GetFloat ("Yyskor");
	}
	
	// Update is called once per frame
	void Update () {
		if(yskore > yyuksekskore){
			yyuksekskore = yskore;
		}
		yskore = yskore + Ziplama.skorartis;
		yyuskeskor.text = yyuksekskore.ToString ();
		skore.text = yskore.ToString ();
		yskor.text = yskore.ToString ();
		PlayerPrefs.SetFloat ("Yyskor", yyuksekskore);
		Ziplama.skore = 0;
	}
}
