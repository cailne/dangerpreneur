using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCopper : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdCooper;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		//holdCooper = PlayerPrefs.GetInt ("Cooper", 0);
	}

	public void UpdateValue(){
		if (PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.CopperPrice >= 0) {
			if (AccessScript.Copper > 0) {
				AccessScript.Copper -= 1;
				holdCooper++;
				PlayerPrefs.SetInt ("Cooper", holdCooper);
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.CopperPrice);
			} else {
				Debug.Log ("Stock Depleted");
			}
		} else {
			Debug.Log ("NOT ENOUGH MONEY");
		}

	}

	void Update() {
		holdCooper = PlayerPrefs.GetInt ("Cooper", 0);
	}
}
