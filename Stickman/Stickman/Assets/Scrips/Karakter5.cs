using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter5 : MonoBehaviour {
	public Sprite Karakter5sprite,K5egilme,K5gozluegilme,K5gozlu;
	public bool K5satinalinmis;
	public bool K5sec,yerde;
	public Text K5secim;
	public string Sec = "Select";
	public string Secili = "Selected";
	public string Satinal = "Buy (100)";
	public static bool K5para;

	// Use this for initialization
	void Start () {
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal;
	}

	// Update is called once per frame
	void Update () {
		if (Ziplama.K5int < 0) {
			K5satinalinmis = true;
		}
		if (K5sec && K5satinalinmis) {
			K5secim.text = Secili;
			K5para = true;
		} 
		if (!K5sec && K5satinalinmis) {
			K5secim.text = Sec;
			K5para = false;
			GetComponent<Animator> ().SetBool ("K5Kullanimda", false);
		}
		if (Ziplama.K5int > -2 && Ziplama.K5int < 0) {
			K5sec = true;
			GetComponent<Animator> ().SetBool ("K5Kullanimda", true);
		}
		if (Ziplama.K5int < -1 && K5satinalinmis) {
			K5sec = false;
		}
		if (Ziplama.K5int > -2 && Ziplama.K5int < 0 && yerde && Goz.gozint > -3 && Goz.gozint < -1) {
			Ziplama.anasprite = Karakter5sprite;
			Ziplama.egilme = K5egilme;
			Ziplama.K1int = 1;
		}
		if (Ziplama.K5int > -2 && Ziplama.K5int < 0 && yerde && Goz.gozint < 0 && Goz.gozint > -2) {
			Ziplama.anasprite = K5gozlu;
			Ziplama.K1int = 1;
			Ziplama.egilme = K5gozluegilme;
		}
		if (Ziplama.K5int > -2 && Ziplama.K5int < 0 && yerde && Goz.gozint > -1) {
			Ziplama.anasprite = Karakter5sprite;
			Ziplama.egilme = K5egilme;
			Ziplama.K1int = 1;
		}
		if (Ziplama.K5satin < 1) {
			Ziplama.K5int = 0;
			K5secim.text = Satinal;
		}
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal + "(500)";
	}
	public void K5botunsecim(){
		if (Ziplama.K5int < 0 && K5satinalinmis) {
			Ziplama.K5int = -1;
			Ziplama.K1int = 1;
			Ziplama.K3int = -2;
			Ziplama.K4int = -2;
			Ziplama.K2int = -2;
		}

	}
	public void K5Buton(){
		if(Ziplama.Money >= 500 && Ziplama.K5int > -1) {
			Ziplama.Money = Ziplama.Money - 500;
			Ziplama.K5int = -1;
			Ziplama.K1int = 1;
			Ziplama.K2int = -2;
			Ziplama.K5satin = 1;
			Ziplama.K3int = -2;
			Ziplama.K4int = -2;

		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Zemin"){
			yerde = true;
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Zemin") {

			yerde = false;
		}
	}



}
