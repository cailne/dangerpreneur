using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour {

	public Text Money;

	void Start() {
		Money.gameObject.SetActive (true);
	}
	void Update() {
		//Debug.Log (MoneyScript.defaultMoney);
		Money.text = "Rp. " + PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney).ToString ();

	}
}
