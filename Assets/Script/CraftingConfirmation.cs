using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingConfirmation : MonoBehaviour {

	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;

	//public PersistentVariables pv;

	public Slider loading;
	private int MaterialID;
	// 1 = Copper, 2 = Gold, 3 = Iron, 4 = Silver, 5 = Rock
	public Text NotEnoughMaterial;

	private bool AllowCraft;

	public float loadingTime;
	public float delayBeforeDisappear;
	private float counter = 0f;

	void Awake() {
		MaterialID = PlayerPrefs.GetInt ("MaterialID");
	}

	void Start() {
		loading.value = 0f;
		loading.gameObject.SetActive (false);

		NotEnoughMaterial.gameObject.SetActive (false);
		AllowCraft = false;
	}

	public void Accept() {
		switch (MaterialID) {
		case 1:
			if (tempCooper >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempCooper--;
				PlayerPrefs.SetInt ("Cooper", tempCooper);

			}
			break;

		case 2:
			if (tempGold >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempGold--;
				PlayerPrefs.SetInt ("Gold", tempCooper);
			}
			break;

		case 3:
			if (tempIron >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempIron--;
				PlayerPrefs.SetInt ("Iron", tempCooper);
			}
			break;

		case 4:
			if (tempSilver >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempSilver--;
				PlayerPrefs.SetInt ("Silver", tempCooper);
			}
			break;
		
		case 5:
			if (tempRock >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempRock--;
				PlayerPrefs.SetInt ("Rock", tempCooper);
			}
			break;
		
		}

		if (AllowCraft == false) {
			NotEnoughMaterial.gameObject.SetActive (true);
		} else {
			NotEnoughMaterial.gameObject.SetActive (false);
		}


	}

	void Update() {
		tempCooper = PlayerPrefs.GetInt ("Cooper", 0);
		tempGold = PlayerPrefs.GetInt ("Gold", 0);
		tempIron = PlayerPrefs.GetInt ("Iron", 0);
		tempRock = PlayerPrefs.GetInt ("Rock", 0);
		tempSilver = PlayerPrefs.GetInt ("Silver", 0);
		tempWood = PlayerPrefs.GetInt ("Wood", 0);

		if (AllowCraft == true) { //MUNCULIN LOADING NYE
			loading.gameObject.SetActive (true);
			counter += Time.deltaTime;
			loading.value = counter / loadingTime;

			if (counter >= loadingTime + delayBeforeDisappear) {
				loading.gameObject.SetActive (false);
				switch(PlayerPrefs.GetInt("WeaponID")){
					case 1:
						if (MaterialID == 1){
							PlayerPrefs.SetInt("ItemID", 50);
							
						}else if (MaterialID == 2){
							PlayerPrefs.SetInt("ItemID", 53);
							
						}else if (MaterialID == 3){
							PlayerPrefs.SetInt("ItemID", 52);

						}else if (MaterialID == 4){
							PlayerPrefs.SetInt("ItemID", 51);

						}else PlayerPrefs.SetInt("ItemID", 54);
					break;

					case 2:
						if (MaterialID == 1){
							PlayerPrefs.SetInt("ItemID", 65);
							
						}else if (MaterialID == 2){
							PlayerPrefs.SetInt("ItemID", 68);
							
						}else if (MaterialID == 3){
							PlayerPrefs.SetInt("ItemID", 67);

						}else if (MaterialID == 4){
							PlayerPrefs.SetInt("ItemID", 66);

						}else PlayerPrefs.SetInt("ItemID", 69);
					break;

					case 3:
						if (MaterialID == 1){
							PlayerPrefs.SetInt("ItemID", 75);
							
						}else if (MaterialID == 2){
							PlayerPrefs.SetInt("ItemID", 78);
							
						}else if (MaterialID == 3){
							PlayerPrefs.SetInt("ItemID", 77);

						}else if (MaterialID == 4){
							PlayerPrefs.SetInt("ItemID", 76);

						}else PlayerPrefs.SetInt("ItemID", 79);
					break;

					case 4:
						if (MaterialID == 1){
							PlayerPrefs.SetInt("ItemID", 15);
							
						}else if (MaterialID == 2){
							PlayerPrefs.SetInt("ItemID", 18);
							
						}else if (MaterialID == 3){
							PlayerPrefs.SetInt("ItemID", 17);

						}else if (MaterialID == 4){
							PlayerPrefs.SetInt("ItemID", 16);

						}else PlayerPrefs.SetInt("ItemID", 19);
					break;
				}
				PersistentVariables.i.addedItem += 1;
				AllowCraft = false;
			}
		}
	}
}
