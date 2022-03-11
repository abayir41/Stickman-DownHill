using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKarakter : MonoBehaviour {
	public bool yerde,Egil;
	public Sprite Ziplama,egilme,Normal;
	public GameObject Yuklemeekrani;
	// Use this for initialization
	void Start () {
		Yuklemeekrani.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!yerde) {
			GetComponent<SpriteRenderer> ().sprite = Ziplama;
		}
		if (yerde) {
			GetComponent<SpriteRenderer> ().sprite = Normal;
		}
		if (Egil) {
			yerde = false;
			GetComponent<SpriteRenderer> ().sprite = egilme;
		} 
		if (!Egil && yerde){
			GetComponent<SpriteRenderer> ().sprite = Normal;
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Zipla"){
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 350);
		}
		if(col.gameObject.tag == "Zemin"){
			yerde = true;
		}
		if(col.gameObject.tag == "Egil"){
			
			GetComponent<Transform> ().Rotate (0, 0, 90);
			Egil = true;
		}
	}
	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Zemin") {

			yerde = false;
		}
		if (col.gameObject.tag == "Kalk") {
			GetComponent<SpriteRenderer> ().sprite = Normal;
			GetComponent<Transform> ().Rotate (0, 0, -90);
			Egil = false;
		}
	}
}