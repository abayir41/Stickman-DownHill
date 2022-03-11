using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dil : MonoBehaviour {
	public static string Oyna,Ayarlar,Cikis,Ses,Efekt,Dilll,Turkce,Geri,Market,Carptin,Skor,YuksekSkor,Tekrar,Market2,Menu,Sec,Secili,Satinal,Oyna2,Menu2,sutun,OyunAd,yapimci;
	public Text Oynat, Ayalart, Cikist, Gerit, Sest, Efektt, Dilt, Turkcet,Sutun,Geri3,Oyunadt,yapimcit;
	public static int Dill;
	public int dilgorunum;
	public bool Turk,Eng;
	// Use this for initialization
	void Start () {
		Dill = PlayerPrefs.GetInt ("Dil");
	
	}
	
	// Update is called once per frame
	void Update () {
		dilgorunum = Dill;
		Oynat.text = Oyna;
		Sutun.text = sutun;
		yapimcit.text = yapimci;
		Ayalart.text = Ayarlar;
		Cikist.text = Cikis;
		Gerit.text = Geri;
		Sest.text = Ses;
		Geri3.text = Geri;
		Efektt.text = Efekt;
		Oyunadt.text = OyunAd;
		Dilt.text = Dilll;
		Turkcet.text = Turkce;
		PlayerPrefs.SetInt ("Dil", Dill);
		if (Dill < 1) {
			Eng = true;
			Turk = false;
			sutun = "Sütunlar";
			OyunAd = "YOKUŞ AŞAĞI";
			Oyna = "Oyna";
			Ayarlar = "Ayarlar";
			Cikis = "Çıkış";
			Ses = "Ses";
			yapimci = "Ahmet BAYIR Tarafından Geliştirildi";
			Efekt = "Efekt Sesleri";
			Dilll = "Dil";
			Turkce = "Türkçe";
			Geri = "Geri";
			Market = "Market";
			Carptin = "Çarptın";
			Skor = "Skor";
			YuksekSkor = "En Yüksek Skor";
			Tekrar = "Tekrar Oyna";
			Market2 = "Market";
			Menu = "Menü";
			Sec = "Seç";
			Secili = "Seçili";
			Satinal = "Satın Al";
			Oyna2 = "Oyna";
			Menu2 = "Menü";
		}
		if (Dill > 0) {
			Turk = true;
			Eng = false;
			sutun = "Blocks";
			OyunAd = "DOWNHİLL";
			Oyna = "Play";
			Ayarlar = "Settings";
			Cikis = "Exit";
			Ses = "Volume";
			Efekt = "Efect Sounds";
			Dilll = "Language";
			Turkce = "English";
			Geri = "Back";
			Market = "Shop";
			Carptin = "Crashed";
			Skor = "Score";
			yapimci = "Developed by Ahmet BAYIR";
			YuksekSkor = "Highest Score";
			Tekrar = "Play Again";
			Market2 = "Shop";
			Menu = "Menu";
			Sec = "Select";
			Secili = "Selected";
			Satinal = "Buy";
			Oyna2 = "Play";
			Menu2 = "Menu";
		}	
	}
	public void Turkces(){
		if (Dill < 1 && Eng) {
			Dill = 1;

		}
	}
	public void English(){
		if (Dill > 0 && Turk) {
			Dill = 0;

		}
	
	}
}
