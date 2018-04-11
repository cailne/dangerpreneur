using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour {

	public Toggle isCooper, isGold, isIron, isRock, isSilver;
	public GameObject BCooper, BGold, BIron, BRock, BSilver;

	MasterItem item;

	private int lethality, durability, weight, price; 

	public Text stats, successMessage;

	private void Start() {
		lethality = 60;
		durability = 23;
		weight = 25;
		price = 500;
	}

	public void ExecuteCraft() {

		if (isCooper.isOn) {
			if (AddInventory.instance.cooper > 0) {
				lethality += Random.Range (1, 5) * -1;
				durability += Random.Range (6, 15);

				AddInventory.instance.cooper--;

				successMessage.gameObject.SetActive (true);
				successMessage.text = "SUCCESSFULLY CRAFT WITH \nCOOPER";
			
			} else {
				Debug.Log ("NOT ENOUGH COOPER");
			}


		} else if (isGold.isOn) {
			if (AddInventory.instance.gold > 0) {
				lethality += Random.Range (6, 15);
				durability += Random.Range (1, 5);
				weight += Random.Range (1, 5);
				price += Random.Range (101, 200);

				AddInventory.instance.gold--;

				successMessage.gameObject.SetActive (true);
				successMessage.text = "SUCCESSFULLY CRAFT WITH \nGOLD";
			
			} else {
				Debug.Log ("NOT ENOUGH GOLD");
			}

		
		} else if (isIron.isOn) {
			if (AddInventory.instance.iron > 0) {
				lethality += Random.Range (1, 5);
				durability += Random.Range (1, 5);
				weight += Random.Range (1, 5);
			
				AddInventory.instance.iron--;	

				successMessage.gameObject.SetActive (true);
				successMessage.text = "SUCCESSFULLY CRAFT WITH \nIRON";

			} else {
				Debug.Log ("NOT ENOUGH IRON");
			}

		
		} else if (isRock.isOn) {
			if (AddInventory.instance.rock > 0) {
				lethality += Random.Range (1, 5);
				durability += Random.Range (1, 5);
				weight += Random.Range (1, 5);

				AddInventory.instance.rock--;

				successMessage.gameObject.SetActive (true);
				successMessage.text = "SUCCESSFULLY CRAFT WITH \nROCK";

			} else {
				Debug.Log ("NOT ENOUGH ROCK");
			}

		
		} else if (isSilver.isOn) {
			if (AddInventory.instance.silver > 0) {
				lethality += Random.Range (6, 15);
				durability += Random.Range (6, 15) * -1;
				weight += Random.Range (1, 5) * -1;
				price += Random.Range (10, 50);

				AddInventory.instance.silver--;

				successMessage.gameObject.SetActive (true);
				successMessage.text = "SUCCESSFULLY CRAFT WITH \nSILVER";

			} else {
				Debug.Log ("NOT ENOUGH SILVER");
			}

		}
	}

	void Update() {
		if (isCooper.isOn) {
			BCooper.SetActive (true);
			BGold.SetActive (false);
			BIron.SetActive (false);
			BRock.SetActive (false);
			BSilver.SetActive (false);
		
		} else if (isGold.isOn) {
			BCooper.SetActive (false);
			BGold.SetActive (true);
			BIron.SetActive (false);
			BRock.SetActive (false);
			BSilver.SetActive (false);
		
		} else if (isIron.isOn) {
			BCooper.SetActive (false);
			BGold.SetActive (false);
			BIron.SetActive (true);
			BRock.SetActive (false);
			BSilver.SetActive (false);
		
		} else if (isRock.isOn) {
			BCooper.SetActive (false);
			BGold.SetActive (false);
			BIron.SetActive (false);
			BRock.SetActive (true);
			BSilver.SetActive (false);
		
		} else if (isSilver.isOn) {
			BCooper.SetActive (false);
			BGold.SetActive (false);
			BIron.SetActive (false);
			BRock.SetActive (false);
			BSilver.SetActive (true);
		}
	}

}
