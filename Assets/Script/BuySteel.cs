using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySteel : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdSteel;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		holdSteel = PlayerPrefs.GetInt ("Steel", 0);
	}

	public void UpdateValue(){
		if (AccessScript.Steel > 0) {
			AccessScript.Steel -= 1;
			holdSteel++;
			PlayerPrefs.SetInt ("Steel", holdSteel);
		} else {
			Debug.Log ("Stock Depleted");
		}
	}
}
