using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyResource : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdIron;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		holdIron = PlayerPrefs.GetInt ("Iron", 0);
	}

	public void UpdateValue(){
		if (AccessScript.Iron > 0) {
			AccessScript.Iron -= 1;
			holdIron++;
			PlayerPrefs.SetInt ("Iron", holdIron);
		} else {
			Debug.Log ("Stock Depleted");
		}
	}

}
