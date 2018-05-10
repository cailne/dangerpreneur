using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGold : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdGold;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		holdGold = PlayerPrefs.GetInt ("Gold", 0);
	}

	public void UpdateValue(){
		if (AccessScript.Gold > 0) {
			AccessScript.Gold -= 1;
			holdGold++;
			PlayerPrefs.SetInt ("Gold", holdGold);
		} else {
			Debug.Log ("Stock Depleted");
		}
	}
}
