using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encyclopedia : MonoBehaviour {

	public GameObject EncyJenawi, EncySiwar, EncyTrisula, EncyGolok;

	/*void Awake() {
		EncyJenawi = GameObject.Find ("EncyclopediaJenawi");
		EncySiwar = GameObject.Find ("EncyclopediaSiwar");
		EncyTrisula = GameObject.Find ("EncyclopediaTrisula");
		EncyGolok = GameObject.Find ("EncyclopediaGolok");
	}*/

	void OnMouseEnter() {
		if (gameObject.name == "Jenawi") {
			EncyJenawi.SetActive (true);
			EncySiwar.SetActive (false);
			EncyTrisula.SetActive (false);
			EncyGolok.SetActive (false);

		} else if (gameObject.name == "Siwar") {
			EncyJenawi.SetActive (false);
			EncySiwar.SetActive (true);
			EncyTrisula.SetActive (false);
			EncyGolok.SetActive (false);
			Debug.Log ("SIWAR ADA");

		} else if (gameObject.name == "Trisula") {
			EncyJenawi.SetActive (false);
			EncySiwar.SetActive (false);
			EncyTrisula.SetActive (true);
			EncyGolok.SetActive (false);

		} else if (gameObject.name == "Golok") {
			EncyJenawi.SetActive (false);
			EncySiwar.SetActive (false);
			EncyTrisula.SetActive (false);
			EncyGolok.SetActive (true);
		}
	}


	void OnMouseExit() {
		EncyJenawi.SetActive (false);
		EncySiwar.SetActive (false);
		EncyTrisula.SetActive (false);
		EncyGolok.SetActive (false);
	}

	/*public void ClosePopUp() {
		gameObject.SetActive (false);
	}*/
}
