using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter4 : MonoBehaviour {

	public Sprite Karakter4sprite,K4egilme,K4gozluegilme,K4gozlu;
	public bool K4satinalinmis;
	public bool K4sec,yerde;
	public Text K4secim;
	public string Sec = "Select";
	public string Secili = "Selected";
	public string Satinal = "Buy (200)";

	// Use this for initialization
	void Start () {
		Sec = Dil2.Sec;
		Secili = Dil2.Secili +  "za";
		Satinal = Dil2.Satinal  +   " (100)";
	}

	// Update is called once per frame
	void Update () {
		if (Ziplama.K4int < 0) {
			K4satinalinmis = true;
		}
		if (K4sec && K4satinalinmis) {
			K4secim.text = Secili;
		} 
		if (!K4sec && K4satinalinmis) {
			K4secim.text = Sec;
			GetComponent<Animator> ().SetBool ("K4Kullanimda", false);
		}
		if (Ziplama.K4int > -2 && Ziplama.K4int < 0) {
			K4sec = true;
			Ziplama.K1int = 1;
			GetComponent<Animator> ().SetBool ("K4Kullanimda", true);
		}
		if (Ziplama.K4int < -1 && K4satinalinmis) {
			K4sec = false;
		}
		if (Ziplama.K4int > -2 && Ziplama.K4int < 0 && yerde && Goz.gozint > -3 && Goz.gozint < -1) {
			Ziplama.anasprite = Karakter4sprite;
			Ziplama.egilme = K4egilme;
			Ziplama.K1int = 1;
		}
		if (Ziplama.K4int > -2 && Ziplama.K4int < 0 && yerde && Goz.gozint < 0 && Goz.gozint > -2) {
			Ziplama.anasprite = K4gozlu;
			Ziplama.egilme = K4gozluegilme;
			Ziplama.K1int = 1;
		}
		if (Ziplama.K4int > -2 && Ziplama.K4int < 0 && yerde && Goz.gozint > -1) {
			Ziplama.anasprite = Karakter4sprite;
			Ziplama.egilme = K4egilme;
			Ziplama.K1int = 1;
		}
		if (Ziplama.K4satin < 1) {
			Ziplama.K4int = 0;
			K4secim.text = Satinal;
		}
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal + "(75)";
	}
	public void K4botunsecim(){
		if (Ziplama.K4int < 0 && K4satinalinmis) {
			Ziplama.K4int = -1;
			Ziplama.K1int = 1;
			Ziplama.K2int = -2;
			Ziplama.K5int = -2;
			Ziplama.K3int = -2;
		}

	}
	public void K4Buton(){
		if(Ziplama.Money >= 75 && Ziplama.K4int > -1) {
			Ziplama.Money = Ziplama.Money - 75;
			Ziplama.K4int = -1;
			Ziplama.K1int = 1;
			Ziplama.K4satin = 1;
			Ziplama.K5int = -2;
			Ziplama.K2int = -2;
			Ziplama.K3int = -2;
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
