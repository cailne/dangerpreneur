using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySilver : MonoBehaviour {

	public GameObject ValueHolder;

	private ShopMgr AccessScript;

	public int holdSilver;
	void Awake(){
		AccessScript = GameObject.FindObjectOfType<ShopMgr> ();
		holdSilver = PlayerPrefs.GetInt ("Silver", 0);
	}

	public void UpdateValue(){
		if (AccessScript.Silver > 0) {
			AccessScript.Silver -= 1;
			holdSilver++;
			PlayerPrefs.SetInt ("Silver", holdSilver);
		} else {
			Debug.Log ("Stock Depleted");
		}
	}
}
