using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod2Spawn1 : MonoBehaviour {
	public GameObject[] engel;
	public Transform yer;
	float sure;
	public float geciktirmesure = 5f;
	// Use this for initialization
	void Start () {
		sure = geciktirmesure;
	}

	// Update is called once per frame
	void Update () {
		sure -= Time.deltaTime;
		if (sure < 0) {

			Instantiate (engel [Random.Range (0, engel.Length)], yer.position, Quaternion.identity);

			sure = geciktirmesure;
			geciktirmesure = geciktirmesure - 0.015f;
		}


	}
}
