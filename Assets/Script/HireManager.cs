using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HireManager : MonoBehaviour {
	//BONUS NYA NYAMBUNG KE SCRIPT GATHER RESOURCE
	private int defaultMoney ;
	private GameObject NotEnoughMoney;
	private float counter;
	void Start() {
		NotEnoughMoney = GameObject.Find ("NotEnoughMoney");
		NotEnoughMoney.gameObject.SetActive (false);
		counter = 0;

		defaultMoney = MoneyScript.defaultMoney;
	}

	public void HireCopper() {
		if(PlayerPrefs.GetInt("Money", defaultMoney) - 75 >= 0) {
			PlayerPrefs.SetInt ("BonusCopper", PlayerPrefs.GetInt ("BonusCopper", 0)+1);
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 75);
			NotEnoughMoney.gameObject.SetActive(false);
		}else {
			NotEnoughMoney.gameObject.SetActive(true);
		}

	}

	public void HireGold() {
		if(PlayerPrefs.GetInt("Money", defaultMoney) - 240 >= 0) {
			PlayerPrefs.SetInt ("BonusGold", PlayerPrefs.GetInt ("BonusGold", 0)+1);
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 240);
			NotEnoughMoney.gameObject.SetActive(false);
		}else {
			NotEnoughMoney.gameObject.SetActive(true);
		}
	
	}

	public void HireIron() {
		if(PlayerPrefs.GetInt("Money", defaultMoney) - 50 >= 0) {
			PlayerPrefs.SetInt ("BonusIron", PlayerPrefs.GetInt ("BonusIron", 0)+1);
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money",defaultMoney) - 50);
			NotEnoughMoney.gameObject.SetActive(false);
		}else {
			NotEnoughMoney.gameObject.SetActive(true);
		}

	}

	public void HireSilver() {
		if (PlayerPrefs.GetInt ("Money", defaultMoney) - 115 >= 0) {
			PlayerPrefs.SetInt ("BonusSilver", PlayerPrefs.GetInt ("BonusSilver", 0) + 1);
			PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 115);
			NotEnoughMoney.gameObject.SetActive (false);
		} else {
			NotEnoughMoney.gameObject.SetActive(true);
		}

	}

	public void HireRock() {
		if (PlayerPrefs.GetInt ("Money", defaultMoney) - 400 >= 0) {
			PlayerPrefs.SetInt ("BonusRock", PlayerPrefs.GetInt ("BonusRock", 0) + 1);
			PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 400);
			NotEnoughMoney.gameObject.SetActive (false);
		} else {
			NotEnoughMoney.gameObject.SetActive (true);
		}

	}

	public void HireWood() {
		if (PlayerPrefs.GetInt ("Money", defaultMoney) - 25 >= 0) {
			PlayerPrefs.SetInt ("BonusWood", PlayerPrefs.GetInt ("BonusWood", 0) + 1);
			PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 25);
			NotEnoughMoney.gameObject.SetActive (false);
		} else {
			NotEnoughMoney.gameObject.SetActive (true);
		}

	}
}
