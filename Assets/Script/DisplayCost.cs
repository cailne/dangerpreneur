using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour {

	private int MaterialID;
	// 1 = Copper, 2 = Gold, 3 = Iron, 4 = Silver, 5 = Rock

	public GameObject ReCooper, ReGold, ReIron, ReSilver, ReRock;
	//Re mksd nya Resource (sprite resourcenye)

	public Text CostOtherWood;
	public Text CostWood;

	void Awake() {
		MaterialID = PlayerPrefs.GetInt ("MaterialID");
	}

	void Start() {
		CostWood.text = "1";
		CostOtherWood.text = "1";

		switch(MaterialID) {
		case 1:
			ReCooper.gameObject.SetActive (true); 
			break;
		case 2:
			ReGold.gameObject.SetActive (true);
			break;
		case 3: 
			ReIron.gameObject.SetActive (true);
			break;
		case 4:
			ReSilver.gameObject.SetActive (true);
			break;
		case 5:
			ReRock.gameObject.SetActive (true);
			break;
		}
	}
}
