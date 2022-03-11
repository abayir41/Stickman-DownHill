using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulut : MonoBehaviour {
	public GameObject[] engel;
	public Transform yer;
	float sure;
	public float geciktirmesure ;
	// Use this for initialization
	void Start () {
		sure = geciktirmesure;

	}

	// Update is called once per frame
	void Update () {
		sure -= Time.deltaTime;
		if (sure < 0) {

			Instantiate (engel [Random.Range (0, engel.Length)],new Vector3 (yer.position.x ,Random.Range(-1,0),yer.position.z), Quaternion.identity);

			sure = geciktirmesure;
			geciktirmesure = Random.Range (5, 10);
		}


	}

}
