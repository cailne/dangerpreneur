using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyerRandomizer : MonoBehaviour {

	public GameObject Bob;
	public GameObject Mafia;
	public GameObject Russian;
	public GameObject Marine;
	float timeRemaining;
	int RandomBuyer;
	public Text BuyerChange;
	// Use this for initialization
	void Start () {
		timeRemaining = 5;
		RandomBuyer = UnityEngine.Random.Range (1, 4);
		Debug.Log (RandomBuyer);
		if (RandomBuyer == 1) {
			Mafia.SetActive (false);
			Russian.SetActive (false);
			Marine.SetActive (false);
			Bob.SetActive (true);
		}if (RandomBuyer == 2) {
			Bob.SetActive (false);
			Russian.SetActive (false);
			Marine.SetActive (false);
			Mafia.SetActive (true);
		}if (RandomBuyer == 3) {
			Mafia.SetActive (false);
			Bob.SetActive (false);
			Marine.SetActive (false);
			Russian.SetActive (true);
		}if (RandomBuyer == 4) {
			Mafia.SetActive (false);
			Russian.SetActive (false);
			Bob.SetActive (false);
			Marine.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
		check();
	}

	void check(){
		if (timeRemaining > 0) {
			BuyerChange.text = "Request will change in : " + (int)timeRemaining;
		} else {
			Start ();
		}
	}
}
