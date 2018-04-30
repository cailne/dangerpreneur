using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMaterial : MonoBehaviour {

	int WeaponID;
	// 1 = Jenawi 2= Siwar 3 = Trisula
	int MaterialID;
	// 1 = Copper, 2 = Gold, 3 = Iron, 4 = Silver, 5 = Rock



	public GameObject JenawiC, JenawiG, JenawiI, JenawiS, JenawiR;
	public GameObject SiwarC, SiwarG, SiwarI, SiwarS, SiwarR;
	public GameObject TrisulaC, TrisulaG, TrisulaI, TrisulaS, TrisulaR;


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
		case 1: //Jenawi
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

		case 2: //Siwar
			switch (MaterialID) {
			case 1:
				SiwarC.SetActive (true);
				break;
			case 2:
				SiwarG.SetActive (true);
				break;
			case 3:
				SiwarI.SetActive (true);
				break;
			case 4:
				SiwarS.SetActive (true);
				break;
			case 5:
				SiwarR.SetActive (true);
				break;

			}

			break;

		case 3: //Trisula
			switch (MaterialID) {
			case 1:
				TrisulaC.SetActive (true);
				break;
			case 2:
				TrisulaG.SetActive (true);
				break;
			case 3:
				TrisulaI.SetActive (true);
				break;
			case 4:
				TrisulaS.SetActive (true);
				break;
			case 5:
				TrisulaR.SetActive (true);
				break;

			}
			break;
			
		}
	}

}
