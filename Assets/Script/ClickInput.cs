using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInput : MonoBehaviour {

	public AddInventory zxc;
	private void Start() {
		zxc = GameObject.Find ("TaroScript").GetComponent<AddInventory> ();
		//Debug.Log (zxc.cooper);
	}

	void OnMouseDown() {
		//Debug.Log (gameObject.name);
		if (EnergyScript.CurrEnergy >= 1) {

			EnergyScript.CurrEnergy--;
			if (gameObject.name == "cooper") {
				zxc.cooper++;
				zxc.cooperText.gameObject.SetActive (true);
			} else if (gameObject.name == "gold") {
				zxc.gold++;
				zxc.goldText.gameObject.SetActive (true);
			} else if (gameObject.name == "iron") {
				zxc.iron++;
				zxc.ironText.gameObject.SetActive (true);
			} else if (gameObject.name == "rock") {
				zxc.rock++;
				zxc.rockText.gameObject.SetActive (true);
			} else if (gameObject.name == "silver") {
				zxc.silver++;
				zxc.silverText.gameObject.SetActive (true);
			} else if (gameObject.name == "wood") {
				zxc.wood++;
				zxc.woodText.gameObject.SetActive (true);
			}
		
		} else {
			Debug.Log ("NOT ENOUGH ENERGY");
		}
	}

	void Update() {
		//Debug.Log (zxc.cooper);
	}
}
