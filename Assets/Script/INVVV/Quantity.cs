using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quantity : MonoBehaviour {

	public Text[] quantityText;
	public int[] quantity = new int[20];
	// Use this for initialization
	void Start () {
		for (int b = 0; b < quantity.Length; b++){
			quantityText[b].text = "Quantity: " + quantity[b].ToString();
		}
	}

	void Update(){
		for (int b = 0; b < quantity.Length; b++){
			quantityText[b].text = "Quantity: " + Inventory.Item[b].ToString();
		}
	}


}
