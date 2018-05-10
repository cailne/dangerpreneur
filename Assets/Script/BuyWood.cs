using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyWood : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdWood;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		holdWood = PlayerPrefs.GetInt ("Wood", 0);
	}

	public void UpdateValue(){
		if (AccessScript.Wood > 0) {
			AccessScript.Wood -= 1;
			holdWood++;
			PlayerPrefs.SetInt ("Wood", holdWood);
		} else {
			Debug.Log ("Stock Depleted");
		}
	}
}
