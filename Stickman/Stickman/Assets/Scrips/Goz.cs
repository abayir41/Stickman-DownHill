using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goz : MonoBehaviour {
	public static bool goz,Gozlu;
	public static int gozint;
	public int deneme;
	public GameObject Kullan,kapat;
	public Text gozsatinn;
	// Use this for initialization
	void Start () {
		GetComponent<Animator> ().SetBool ("Gozlu", false);
		gozint = PlayerPrefs.GetInt ("goz");
		Kullan.SetActive (false);
		kapat.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		deneme = gozint;
		PlayerPrefs.SetInt ("goz", gozint);
		if (gozint < 0) {
			goz = true;
		}
		if (gozint < 0 && gozint > -2) {
			GetComponent<Animator> ().SetBool ("Gozlu", true);
			Kullan.SetActive (true);
			kapat.SetActive (false);
		}
		if (gozint < -1 && gozint > -3) {
			GetComponent<Animator> ().SetBool ("Gozlu", false);
			Kullan.SetActive (false);
			kapat.SetActive (true);
		}
		gozsatinn.text = Dil2.Satinal + "(150)";
	}
	public void GozSatin(){
		if(Ziplama.Money >= 150 && gozint > -1){
			Ziplama.Money = Ziplama.Money - 150;
			gozint = -1;
			goz = true;
		}
	}
	public void GozKullan(){
		if (goz) {
			gozint = -1;
		}
	}
	public void GozKapat(){
			if (goz) {
			gozint = -2;
		}
	}
}
