using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyResource : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdIron;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		//holdIron = PlayerPrefs.GetInt ("Iron", 0);
	}

	public void UpdateValue(){

		if (PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.IronPrice >= 0) {
			if (AccessScript.Iron > 0) {
				AccessScript.Iron -= 1;
				holdIron++;
				PlayerPrefs.SetInt ("Iron", holdIron);
				PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) - AccessScript.IronPrice);
			} else {
				Debug.Log ("Stock Depleted");
			}
		} else {
			Debug.Log ("NOT ENOUGH MONEY");
		}

	}

	void Update() {
		holdIron = PlayerPrefs.GetInt ("Iron", 0);
	}

}
