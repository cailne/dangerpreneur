using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HireManager : MonoBehaviour {
	//BONUS NYA NYAMBUNG KE SCRIPT GATHER RESOURCE
	public int defaultMoney;
	public void HireCopper() {
		PlayerPrefs.SetInt ("BonusCopper", PlayerPrefs.GetInt ("BonusCopper", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 75);
	}

	public void HireGold() {
		PlayerPrefs.SetInt ("BonusGold", PlayerPrefs.GetInt ("BonusGold", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money", defaultMoney) - 240);
	}

	public void HireIron() {
		PlayerPrefs.SetInt ("BonusIron", PlayerPrefs.GetInt ("BonusIron", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money",defaultMoney) - 50);
	}

	public void HireSilver() {
		PlayerPrefs.SetInt ("BonusSilver", PlayerPrefs.GetInt ("BonusSilver", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money",defaultMoney) - 115);
	}

	public void HireRock() {
		PlayerPrefs.SetInt ("BonusRock", PlayerPrefs.GetInt ("BonusRock", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money",defaultMoney) - 400);
	}

	public void HireWood() {
		PlayerPrefs.SetInt ("BonusWood", PlayerPrefs.GetInt ("BonusWood", 0)+1);
		PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt ("Money",defaultMoney) - 25);
	}
}
