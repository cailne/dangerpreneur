using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherResource : MonoBehaviour {
	public GameObject cooper, gold,iron,rock,silver, wood;


	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;
	public Text cooperT, goldT, ironT, rockT, silverT, woodT;



	void Awake() { //SUPAYA GA NAMBAH TEROS
		//PlayerPrefs.DeleteAll ();
	
	}

	void Start() {
		tempCooper = PlayerPrefs.GetInt ("Cooper", 0);
		tempGold = PlayerPrefs.GetInt ("Gold", 0);
		tempIron = PlayerPrefs.GetInt ("Iron", 0);
		tempRock = PlayerPrefs.GetInt ("Rock", 0);
		tempSilver = PlayerPrefs.GetInt ("Silver", 0);
		tempWood = PlayerPrefs.GetInt ("Wood", 0);

	}

	void OnMouseUp() {
		if (EnergyScript.CurrEnergy >= 1) {
			EnergyScript.CurrEnergy--; 
			if (gameObject.name == "SUMATERA") {
				tempSilver += 1;
				PlayerPrefs.SetInt ("Silver", tempSilver);
				//silverT.text = tempSilver.ToString ();



				//Showing Cooper for 1 second
				/*silver.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
			Vector3 location = new Vector3 (-8.5f, -0.06451121f, -9.959233f);
			GameObject clone = (GameObject)Instantiate (silver, location, transform.rotation);
			Destroy (clone, 5.0f);*/
				//GW GK TW INI KENAPA GK NONGOL DI LAYAR GAME NYE, DI SCENE KELUAR 

			} else if (gameObject.name == "KALIMANTAN") {
				tempIron += 1;
				PlayerPrefs.SetInt ("Iron", tempIron);
				//ironT.text = tempIron.ToString ();

			} else if (gameObject.name == "SULAWESI") {
				tempCooper += 1;
				PlayerPrefs.SetInt ("Cooper", tempCooper);
				//cooperT.text = tempCooper.ToString ();

			} else if (gameObject.name == "PAPUA") {
				tempGold += 1;
				PlayerPrefs.SetInt ("Gold", tempGold);
				//goldT.text = tempGold.ToString ();

			} else if (gameObject.name == "NTT NTB") {
				tempWood += 1;
				PlayerPrefs.SetInt ("Wood", tempWood);

				//woodT.text = tempWood.ToString ();

			} else if (gameObject.name == "MALUKU") {
				tempWood += 1;
				PlayerPrefs.SetInt ("Wood", tempWood);

				//woodT.text = tempWood.ToString ();
			
			} else if (gameObject.name == "JAWA") {
				tempRock += 1;
				PlayerPrefs.SetInt ("Rock", tempRock);

				//rockT.text = tempRock.ToString ();
			}

		}


	}

	void Update() {
		tempCooper = PlayerPrefs.GetInt ("Cooper", 0);
		tempGold = PlayerPrefs.GetInt ("Gold", 0);
		tempIron = PlayerPrefs.GetInt ("Iron", 0);
		tempRock = PlayerPrefs.GetInt ("Rock", 0);
		tempSilver = PlayerPrefs.GetInt ("Silver", 0);
		tempWood = PlayerPrefs.GetInt ("Wood", 0);

		cooperT.text = tempCooper.ToString();
		goldT.text = tempGold.ToString();
		ironT.text = tempIron.ToString();
		rockT.text = tempRock.ToString();
		silverT.text = tempSilver.ToString();
		woodT.text = tempWood.ToString();


	}

	public GameObject popUP;
	void OnMouseEnter() {
		popUP.SetActive (true);
	}

	void OnMouseExit() {
		popUP.SetActive (false);
	}
}
