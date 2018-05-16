using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySteel : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdSteel;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		//holdSteel = PlayerPrefs.GetInt ("Steel", 0);
	}

	public void UpdateValue(){

		if (PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.SteelPrice >= 0) {
			if (AccessScript.Steel > 0) {
				AccessScript.Steel -= 1;
				holdSteel++;
				PlayerPrefs.SetInt ("Steel", holdSteel);
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.SteelPrice);
			} else {
				Debug.Log ("Stock Depleted");
			}
		} else {
			Debug.Log ("NOT ENOUGH MONEY");
		}

	}

	void Update() {
		holdSteel = PlayerPrefs.GetInt ("Steel", 0);
	}
}
