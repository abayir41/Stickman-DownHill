using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dil2 : MonoBehaviour {
	public static string Market,Carptin,Skor,YuksekSkor,Tekrar,Market2,Menu,Sec,Secili,Satinal,Oyna2,Menu2,Devam,eyes,kullan,kapat;
	public Text Markett, Carptint, Skort, Yuksekskort, Tekrart, Market2t, Menut, Oyna2t, Menu2t,Skor2t,Devamt,Tekrar2t,Market3t,Menu3t,eyest,kullant,kapatt;
	public int Dill;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Dill = PlayerPrefs.GetInt ("Dil");
		Devamt.text = Devam;
		kullant.text = kullan;
		kapatt.text = kapat;
		eyest.text = eyes;
		Tekrar2t.text = Tekrar;
		Market3t.text = Market;
		Menu3t.text = Menu;
		Markett.text = Market;
		Carptint.text = Carptin;
		Skort.text = Skor;
		Yuksekskort.text = YuksekSkor;
		Tekrart.text = Tekrar;
		Market2t.text = Market2;
		Menut.text = Menu;
		Oyna2t.text = Oyna2;
		Menu2t.text = Menu2;
		Skor2t.text = Skor;
		if (Dill < 1) {
			Devam = "Devam";
			kullan = "Kullan";
			kapat = "Kullanma";
			eyes = "Çubuk Adamlar İçin Gözler";
			Market = "Market";
			Carptin = "Çarptın";
			Skor = "Skor:";
			YuksekSkor = "En Yüksek Skor:";
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
			Devam = "Play";
			kullan = "Enable";
			kapat = "Disable";
			eyes = "Eyes For Stickmans";
			Market = "Shop";
			Carptin = "You Crashed";
			Skor = "Score:";
			YuksekSkor = "Highest Score:";
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
	}
