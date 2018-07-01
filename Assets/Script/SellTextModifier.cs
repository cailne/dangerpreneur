using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellTextModifier : MonoBehaviour {

	public Text setter;
	void Start () {
		setter.text = "Multiplier\n" + PlayerPrefs.GetFloat("ShopMM");
	}
	
	
}
