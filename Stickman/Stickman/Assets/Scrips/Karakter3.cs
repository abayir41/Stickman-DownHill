using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter3 : MonoBehaviour {
	public Sprite Karakter3sprite,K3egilme;
	public bool K3satinalinmis;
	public bool K3sec,yerde;
	public Text K3secim;
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
		if (Ziplama.K3int < 0) {
			K3satinalinmis = true;
		}
		if (K3sec && K3satinalinmis) {
			K3secim.text = Secili;
		} 
		if (!K3sec && K3satinalinmis) {
			K3secim.text = Sec;
			GetComponent<Animator> ().SetBool ("K3kullanimda", false);
		}
		if (Ziplama.K3int > -2 && Ziplama.K3int < 0) {
			Ziplama.K1int = 1;
			K3sec = true;
			GetComponent<Animator> ().SetBool ("K3kullanimda", true);
		}
		if (Ziplama.K3int < -1 && K3satinalinmis) {
			K3sec = false;
		}
		if (Ziplama.K3int > -2 && Ziplama.K3int < 0 && yerde) {
			Ziplama.anasprite = Karakter3sprite;
			Ziplama.egilme = K3egilme;
		}
		if (Ziplama.K3satin < 1) {
			Ziplama.K3int = 0;
			K3secim.text = Satinal;
		}
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal + "(200)";
	}
	public void K3botunsecim(){
		if (Ziplama.K3int < 0 && K3satinalinmis) {
			Ziplama.K3int = -1;
			Ziplama.K1int = 1;
			Ziplama.K2int = -2;
			Ziplama.K4int = -2;
			Ziplama.K5int = -2;
		}

	}
	public void K3Buton(){
		if(Ziplama.Money >= 200 && Ziplama.K3int > -1) {
			Ziplama.Money = Ziplama.Money - 200;
			Ziplama.K3int = -1;
			Ziplama.K1int = 1;
			Ziplama.K3satin = 1;
			Ziplama.K2int = -2;
			Ziplama.K4int = -2;
			Ziplama.K5int = -2;
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
