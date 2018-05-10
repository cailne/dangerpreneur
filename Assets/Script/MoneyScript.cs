using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour {

	public Text MoneyText;
	public int defaultMoney;
	int currentMoney;

	void Awake() {
		currentMoney = PlayerPrefs.GetInt ("Money", defaultMoney);
	}

	void Update() {
		MoneyText.text = currentMoney.ToString ();
	}


}
