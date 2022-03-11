using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ziplama : MonoBehaviour {
	public bool yerde = false;
	public AudioSource Ziplaamaa;
	public AudioClip ziplaa,paraaaacapma;
	public bool Panel,Market_panel,paneller;
	public GameObject olum_panel,canvas;
	public float guc;
	public static float skore;
	public float yuksekskore;
	public static float skorartis;
	public Text Skor,score,yuksekskor;
	public Sprite ziplamasprite,baslangic;
	public bool egil;
	public GameObject durdurmaC,DurdurmaC2;
	public GameObject gozSatin, Gozsatin2,ggozsatin;
	//Market---------------------------------
	public static int K1int;
	public static int K2int;
	public static int Money;
	public static int K2satin;
	public static int K3int;
	public static int K3satin;
	public static int K4int;
	public static int K4satin;
	public static int K5int;
	public static int K5satin;
	public GameObject market_panel;
	public Text para;
	public static Sprite anasprite,egilme;
	//Market-----------------------------

	// Use this for initialization
	void Start () {
		Ziplaamaa = GetComponent<AudioSource> ();
		Time.timeScale = 1;
		Panel = false;
		skorartis = 1;
		skore = 0;
		market_panel.SetActive (false);
		paneller = true;
		Money = PlayerPrefs.GetInt ("Money");
		K1int = PlayerPrefs.GetInt ("Ka1");
		K2int = PlayerPrefs.GetInt ("Ka2");
		K2satin = PlayerPrefs.GetInt ("K2satin");
		K3satin = PlayerPrefs.GetInt ("K3satin");
		K3int = PlayerPrefs.GetInt ("Ka3");
		K4satin = PlayerPrefs.GetInt ("K4satin");
		K4int = PlayerPrefs.GetInt ("Ka4");
		K5satin = PlayerPrefs.GetInt ("K5satin");
		K5int = PlayerPrefs.GetInt ("Ka5");
		yuksekskore = PlayerPrefs.GetFloat ("Yskor");
		GetComponent<SpriteRenderer> ().sprite = anasprite;
		anasprite = baslangic;
		durdurmaC.SetActive (false);
	}
	


	// Update is called once per frame
	void Update () {
		if (Goz.gozint < 0) {
			gozSatin.SetActive (false);
			Gozsatin2.SetActive (true);
			ggozsatin.SetActive (true);
		}
		if (Goz.gozint > -1) {
			gozSatin.SetActive (true);
			Gozsatin2.SetActive (false);
			ggozsatin.SetActive (false);
		}
		if(skore > yuksekskore){
			yuksekskore = skore;
			
		}
		if (Panel) {
			olum_panel.SetActive (true);
		} else {
			olum_panel.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.W) && yerde && !egil) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * guc);
		}
		skore = skorartis + skore;
		Skor.text = skore.ToString ();
		score.text = skore.ToString ();
		if (!yerde) {
			GetComponent<SpriteRenderer> ().sprite = ziplamasprite;
		} else {
			GetComponent<SpriteRenderer> ().sprite = anasprite;
		
		} 
		if (!paneller) {
			canvas.SetActive (false);
		} else {
			canvas.SetActive (true);
		}
		if (egil) {
			GetComponent<SpriteRenderer> ().sprite = egilme;
		}	
		yuksekskor.text = yuksekskore.ToString ();
		GetComponent<Animator> ().SetBool ("Yerde", yerde);
		para.text = Money.ToString ();
		PlayerPrefs.SetInt ("Ka1", K1int);
		PlayerPrefs.SetInt ("Ka2", K2int);
		PlayerPrefs.SetInt ("Money", Money);
		PlayerPrefs.SetInt ("K2satin", K2satin);
		PlayerPrefs.SetInt ("K3satin", K3satin);
		PlayerPrefs.SetInt ("Ka3", K3int);
		PlayerPrefs.SetInt ("K4satin", K4satin);
		PlayerPrefs.SetInt ("Ka4", K4int);
		PlayerPrefs.SetInt ("K5satin", K5satin);
		PlayerPrefs.SetInt ("Ka5", K5int);
		PlayerPrefs.SetFloat ("Yskor", yuksekskore);
//		Money = PlayerPrefs.GetInt ("Money");
//		K1int = PlayerPrefs.GetInt ("Ka1");
//		K2int = PlayerPrefs.GetInt ("Ka2");
//		K2satin = PlayerPrefs.GetInt ("K2satin");
//		K3satin = PlayerPrefs.GetInt ("K3satin");
	}


	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Zemin"){
			yerde = true;
		}
		if (col.gameObject.tag == "Engel") {
			Panel = true;
			Time.timeScale = 0;
			transform.localPosition = transform.position + new Vector3 (0, 20f, 0);
			skorartis = 0;
			DurdurmaC2.SetActive (false);
		}
		if (col.gameObject.tag == "para" && !Karakter5.K5para) {
			Money = Money + 5;
			Ziplaamaa.PlayOneShot (paraaaacapma, 1f);
		}
		if (col.gameObject.tag == "para" && Karakter5.K5para) {
			Money = Money + 10;
			Ziplaamaa.PlayOneShot (paraaaacapma, 1f);
		}
	}



	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Zemin") {

			yerde = false;
		}
	}


	public void egilmeani(){
		if (yerde) {
			GetComponent<Transform> ().Rotate (0, 0, 90);
			egil = true;
		}
	}	
	public void kalkmaani(){
		if (egil) {
			GetComponent<Transform> ().Rotate (0, 0, -90);
			egil = false;
		}
	}
	public void zipla(){
		if (yerde && !egil) {
			Ziplaamaa.PlayOneShot (ziplaa, 1f);
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * guc);
			yerde = false;

		}
			
	}

	public void Market_buton(){
		market_panel.SetActive (true);
		paneller = false;
		durdurmaC.SetActive (false);
		DurdurmaC2.SetActive (false);
	}
}


