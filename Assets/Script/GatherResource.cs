using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherResource : MonoBehaviour {
	public GameObject cooper, gold,iron,rock,silver, wood;


	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;
	public Text cooperT, goldT, ironT, rockT, silverT, woodT;

	private int tempJati, tempMahoni, tempMeranti, tempUlin;

	void Awake() { //SUPAYA GA NAMBAH TEROS
		PlayerPrefs.DeleteAll ();
		/*PlayerPrefs.DeleteKey ("Cooper");
		PlayerPrefs.DeleteKey ("Gold");
		PlayerPrefs.DeleteKey ("Iron");
		PlayerPrefs.DeleteKey ("Rock");
		PlayerPrefs.DeleteKey ("Silver");
		PlayerPrefs.DeleteKey ("Jati");
		PlayerPrefs.DeleteKey ("Mahoni");
		PlayerPrefs.DeleteKey ("Meranti");
		PlayerPrefs.DeleteKey ("Ulin");*/
	}

	void Start() {
		
		tempCooper = PlayerPrefs.GetInt ("Cooper", 0);
		tempGold = PlayerPrefs.GetInt ("Gold", 0);
		tempIron = PlayerPrefs.GetInt ("Iron", 0);
		tempRock = PlayerPrefs.GetInt ("Rock", 0);
		tempSilver = PlayerPrefs.GetInt ("Silver", 0);
		//tempWood = PlayerPrefs.GetInt ("Wood", 0);

		//WOOD = JATI + MAHONI + MERANTI + ULIN
		tempJati = PlayerPrefs.GetInt("Jati", 0);
		tempMahoni = PlayerPrefs.GetInt ("Mahoni", 0);
		tempMeranti = PlayerPrefs.GetInt ("Meranti", 0);
		tempUlin = PlayerPrefs.GetInt ("Ulin", 0);

	}

	void Update() {
		tempWood = tempJati + tempMahoni + tempMeranti + tempUlin;
	}

	void OnMouseDown() {
		if (EnergyScript.CurrEnergy >= 1) {
			EnergyScript.CurrEnergy--; 
			if (gameObject.name == "SUMATERA") {
				tempSilver += 1;
				PlayerPrefs.SetInt ("Silver", tempSilver);
				silverT.text = tempSilver.ToString ();



				//Showing Cooper for 1 second
				/*silver.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
			Vector3 location = new Vector3 (-8.5f, -0.06451121f, -9.959233f);
			GameObject clone = (GameObject)Instantiate (silver, location, transform.rotation);
			Destroy (clone, 5.0f);*/
				//GW GK TW INI KENAPA GK NONGOL DI LAYAR GAME NYE, DI SCENE KELUAR 

			} else if (gameObject.name == "KALIMANTAN") {
				tempIron += 1;
				PlayerPrefs.SetInt ("Iron", tempIron);
				ironT.text = tempIron.ToString ();

			} else if (gameObject.name == "SULAWESI") {
				tempCooper += 1;
				PlayerPrefs.SetInt ("Cooper", tempCooper);
				cooperT.text = tempCooper.ToString ();

			} else if (gameObject.name == "PAPUA") {
				tempGold += 1;
				PlayerPrefs.SetInt ("Gold", tempGold);
				goldT.text = tempGold.ToString ();

			} else if (gameObject.name == "NTT NTB") {
				tempJati += 1;
				tempMahoni += 1;

				PlayerPrefs.SetInt ("Jati", tempJati);
				PlayerPrefs.SetInt ("Mahoni", tempMahoni);

				woodT.text = tempWood.ToString ();

			} else if (gameObject.name == "MALUKU") {
				tempMeranti += 1;
				tempUlin += 1;

				PlayerPrefs.SetInt ("Meranti", tempMeranti);
				PlayerPrefs.SetInt ("Ulin", tempUlin);

				woodT.text = tempWood.ToString ();
			}

		}


	}
}
