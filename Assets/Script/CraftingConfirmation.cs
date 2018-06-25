using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingConfirmation : MonoBehaviour {

	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;

	//public PersistentVariables pv;

	public MsItem siwar1,siwar2,siwar3,siwar4,siwar5;
	public MsItem trisula1,trisula2,trisula3,trisula4,trisula5;
	public MsItem golok1,golok2,golok3,golok4,golok5;
	public MsItem jenawi1,jenawi2,jenawi3,jenawi4,jenawi5;

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
							Inventory.instance.Add(jenawi1);
							
						}else if (MaterialID == 2){
							Inventory.instance.Add(jenawi2);
							
						}else if (MaterialID == 3){
							Inventory.instance.Add(jenawi3);

						}else if (MaterialID == 4){
							Inventory.instance.Add(jenawi4);

						}else Inventory.instance.Add(jenawi5);
					break;

					case 2:
						if (MaterialID == 1){
							Inventory.instance.Add(siwar1);
							
						}else if (MaterialID == 2){
							Inventory.instance.Add(siwar2);
							
						}else if (MaterialID == 3){
							Inventory.instance.Add(siwar3);

						}else if (MaterialID == 4){
							Inventory.instance.Add(siwar4);

						}else Inventory.instance.Add(siwar5);
					break;

					case 3:
						if (MaterialID == 1){
							Inventory.instance.Add(trisula1);
							
						}else if (MaterialID == 2){
							Inventory.instance.Add(trisula2);
							
						}else if (MaterialID == 3){
							Inventory.instance.Add(trisula3);

						}else if (MaterialID == 4){
							Inventory.instance.Add(trisula4);

						}else Inventory.instance.Add(trisula5);
					break;

					case 4:
						if (MaterialID == 1){
							Inventory.instance.Add(golok1);
							
						}else if (MaterialID == 2){
							Inventory.instance.Add(golok2);
							
						}else if (MaterialID == 3){
							Inventory.instance.Add(golok3);

						}else if (MaterialID == 4){
							Inventory.instance.Add(golok4);

						}else Inventory.instance.Add(golok5);
					break;
				}
				//PersistentVariables.i.addedItem += 1;
				AllowCraft = false;
				
			}
		}
	}
}
