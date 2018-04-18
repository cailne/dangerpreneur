using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMaterial : MonoBehaviour {

	int WeaponID;
	// 1 = Jenawi
	int MaterialID;
	// 1 = Copper, 2 = Gold, 3 = Iron, 4 = Silver, 5 = Rock



	public GameObject JenawiC, JenawiG, JenawiI, JenawiS, JenawiR;


	private void Awake() {
		WeaponID = PlayerPrefs.GetInt ("WeaponID");
		MaterialID = PlayerPrefs.GetInt ("MaterialID");


	}
	void Start() {

		Debug.Log (MaterialID);
		/*if (WeaponID == 1 && MaterialID == 1) {
			JenawiC.SetActive (true);
		}*/
		switch (WeaponID) {
		case 1:
			switch (MaterialID) {
			case 1:
				JenawiC.SetActive (true);
				break;
			case 2:
				JenawiG.SetActive (true);
				break;
			case 3:
				JenawiI.SetActive (true);
				break;
			case 4:
				JenawiS.SetActive (true);
				break;
			case 5:
				JenawiR.SetActive (true);
				break;
				
			}

			break;
		}
	}

}
