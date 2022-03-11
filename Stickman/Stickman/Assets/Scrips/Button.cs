using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour {
	public GameObject MenuC;
	public GameObject AyarlarC;
	public GameObject DurdurmaC;
	public GameObject Yazi;
	public GameObject Oyunsecim;
	public static int Durdurmaint;
	// Use this for initialization
	public void Level(){
		SceneManager.LoadScene (1);
	}
	public void yavas(){
		SceneManager.LoadScene (2);
	}
	public void Load_Level(int Level_Index){
		StartCoroutine (Load_Progress (Level_Index));
	}
	public void Menu(){
		Time.timeScale = 1;
		SceneManager.LoadScene (0);

	}
	public void Quit(){
		Application.Quit();
	}
	public void Ayarlar(){
		MenuC.SetActive (false);
		AyarlarC.SetActive (true);
	}
	public void Ayarlargeri(){
		MenuC.SetActive (true);
		AyarlarC.SetActive (false);
		Oyunsecim.SetActive (false);
	}
	public void Durdurma(){
		Time.timeScale = 0;
		Hareket.Durdurmakont = 0;
		Hareket.hiz2 = 0;
		Hareket2.hiz1 = 0;
		Ziplama.skorartis = 0;
		DurdurmaC.SetActive (true);
		Durdurmaint = 1;
	}
	public void Music (){
		Yazi.SetActive (true);
	}
	public void Devam (){
		Hareket.Durdurmakont = 1;
		Time.timeScale = 1;
		Ziplama.skorartis = 1;
		DurdurmaC.SetActive (false);

		Hareket.hiz2 = 0.00007f;
		Hareket2.hiz1 = 0.00007f;
	}
	public void Oyna(){
		Oyunsecim.SetActive (true);
		MenuC.SetActive (false);
	}
	void Start () {
		Yazi.SetActive (false);
		AyarlarC.SetActive (false);
		Oyunsecim.SetActive (false);
		DurdurmaC.SetActive (false);

	}
	IEnumerator Load_Progress(int Level_Index){
		AsyncOperation Opreration = SceneManager.LoadSceneAsync (Level_Index);
		while (!Opreration.isDone) {
			Yuklemeekran.yukleme = Mathf.Clamp01 (Opreration.progress / 0.9f);
			Debug.Log (Yuklemeekran.yukleme);
			yield return null;
		}
	}



	// Update is called once per frame
	void Update(){
	}	

}
