using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour {

	public Text MoneyText;
	public static int defaultMoney;


	void Start() {
		defaultMoney = 5000;
	}

	void Update() {
		MoneyText.text = PlayerPrefs.GetInt("Money", defaultMoney).ToString ();

	}


}
