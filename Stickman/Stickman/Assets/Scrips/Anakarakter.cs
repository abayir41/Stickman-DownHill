using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Anakarakter : MonoBehaviour {
	public bool K1sec,yerde;
	public Text K1secim;
	public string Sec = "Select";
	public string Secili = "Selected";
	public Sprite anakarakter1,anaegilme,gozluegilme,gozlukarakter;

	// Use this for initialization
	void Start () {
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ziplama.K1int < 1) {
			K1sec = true;
			GetComponent<Animator> ().SetBool ("Anakkullanimda", true);
		} else {
			K1sec = false;
			GetComponent<Animator> ().SetBool ("Anakkullanimda", false);
		}
		if (K1sec) {
			K1secim.text = Secili;
		} else {
			K1secim.text = Sec;
		}
		if (Ziplama.K1int < 1 && yerde && Goz.gozint > -3 && Goz.gozint < -1) {
			Ziplama.anasprite = anakarakter1;
			Ziplama.egilme = anaegilme;
		}
		if (Ziplama.K1int < 1 && yerde && Goz.gozint < 0 && Goz.gozint > -2) {
			Ziplama.anasprite = gozlukarakter;
			Ziplama.egilme = gozluegilme;
		}
		if (Ziplama.K1int < 1 && yerde && Goz.gozint > -1) {
			Ziplama.anasprite = anakarakter1;
			Ziplama.egilme = anaegilme;
		}
		Sec = Dil2.Sec;
		Secili = Dil2.Secili;
	
	
	}
	public void K1Buton(){
		if (Ziplama.K1int > 0 ) {
			Ziplama.K1int = 0;
			Ziplama.K5int = -2;
			Ziplama.K2int = -2;
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