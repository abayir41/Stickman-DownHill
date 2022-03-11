using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karakter2 : MonoBehaviour {
	public Sprite Karakter2sprite,K2egilme;
	public bool K2satinalinmis;
	public bool K2sec,yerde;
	public Text K2secim;
	public string Sec = "Select";
	public string Secili = "Selected";
	public string Satinal = "Buy (100)";

	// Use this for initialization
	void Start () {
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ziplama.K2int < 0) {
			K2satinalinmis = true;
		}
		if (K2sec && K2satinalinmis) {
			K2secim.text = Secili;
		} 
		if (!K2sec && K2satinalinmis) {
			K2secim.text = Sec;
			GetComponent<Animator> ().SetBool ("K2Kullanimda", false);
		}
		if (Ziplama.K2int > -2 && Ziplama.K2int < 0) {
			Ziplama.K1int = 1;
			K2sec = true;
			GetComponent<Animator> ().SetBool ("K2Kullanimda", true);
		}
		if (Ziplama.K2int < -1 && K2satinalinmis) {
			K2sec = false;
		}
		if (Ziplama.K2int > -2 && Ziplama.K2int < 0 && yerde) {
			Ziplama.anasprite = Karakter2sprite;
			Ziplama.egilme = K2egilme;
		}
		if (Ziplama.K2satin < 1) {
			Ziplama.K2int = 0;
			K2secim.text = Satinal;
		}
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
		Satinal = Dil2.Satinal + "(100)";
	}
	public void K2botunsecim(){
		if (Ziplama.K2int < 0 && K2satinalinmis) {
			Ziplama.K2int = -1;
			Ziplama.K1int = 1;
			Ziplama.K3int = -2;
			Ziplama.K4int = -2;
			Ziplama.K5int = -2;
		}

	}
	public void K2Buton(){
		if(Ziplama.Money >= 100 && Ziplama.K2int > -1) {
				Ziplama.Money = Ziplama.Money - 100;
				Ziplama.K2int = -1;
			Ziplama.K1int = 1;
			Ziplama.K2satin = 1;
			Ziplama.K3int = -2;
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