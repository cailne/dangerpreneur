using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CraftingConfirmation : MonoBehaviour {

	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;

	//public PersistentVariables pv;

	/*public MsItem siwar1,siwar2,siwar3,siwar4,siwar5;
	public MsItem trisula1,trisula2,trisula3,trisula4,trisula5;
	public MsItem golok1,golok2,golok3,golok4,golok5;
	public MsItem jenawi1,jenawi2,jenawi3,jenawi4,jenawi5;*/

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

        switch (PlayerPrefs.GetInt("WeaponID"))
        {
            case 1:
                if (MaterialID == 1)
                {
                    Inventory.Item[0] += 1;

                }
                else if (MaterialID == 2)
                {
                    Inventory.Item[1] += 1;

                }
                else if (MaterialID == 3)
                {
                    Inventory.Item[2] += 1;

                }
                else if (MaterialID == 4)
                {
                    Inventory.Item[3] += 1;

                }
                else Inventory.Item[4] += 1;
                break;

            case 2:
                if (MaterialID == 1)
                {
                    Inventory.Item[5] += 1;

                }
                else if (MaterialID == 2)
                {
                    Inventory.Item[6] += 1;

                }
                else if (MaterialID == 3)
                {
                    Inventory.Item[7] += 1;

                }
                else if (MaterialID == 4)
                {
                    Inventory.Item[8] += 1;

                }
                else Inventory.Item[9] += 1;
                break;

            case 3:
                if (MaterialID == 1)
                {
                    Inventory.Item[10] += 1;

                }
                else if (MaterialID == 2)
                {
                    Inventory.Item[11] += 1;
                }
                else if (MaterialID == 3)
                {
                    Inventory.Item[12] += 1;

                }
                else if (MaterialID == 4)
                {
                    Inventory.Item[13] += 1;

                }
                else Inventory.Item[14] += 1;
                break;

            case 4:
                if (MaterialID == 1)
                {
                    Inventory.Item[15] += 1;

                }
                else if (MaterialID == 2)
                {
                    Inventory.Item[16] += 1;

                }
                else if (MaterialID == 3)
                {
                    Inventory.Item[17] += 1;

                }
                else if (MaterialID == 4)
                {
                    Inventory.Item[18] += 1;

                }
                else Inventory.Item[19] += 1;
                break;
        }
        //PersistentVariables.i.addedItem += 1;

        switch (MaterialID) {
		case 1:
			if (tempCooper >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempCooper--;
				PlayerPrefs.SetInt ("Cooper", tempCooper);
				PlayerPrefs.SetInt ("Wood", PlayerPrefs.GetInt ("Wood", 0) - 1);

			}
			break;

		case 2:
			if (tempGold >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempGold--;
				PlayerPrefs.SetInt ("Gold", tempGold);
				PlayerPrefs.SetInt ("Wood", PlayerPrefs.GetInt ("Wood", 0) - 1);
			}
			break;

		case 3:
			if (tempIron >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempIron--;
				PlayerPrefs.SetInt ("Iron", tempIron);
				PlayerPrefs.SetInt ("Wood", PlayerPrefs.GetInt ("Wood", 0) - 1);
			}
			break;

		case 4:
			if (tempSilver >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempSilver--;
				PlayerPrefs.SetInt ("Silver", tempSilver);
				PlayerPrefs.SetInt ("Wood", PlayerPrefs.GetInt ("Wood", 0) - 1);
			}
			break;
		
		case 5:
			if (tempRock >= 1 && tempWood >= 1) {
				AllowCraft = true;
				tempRock--;
				PlayerPrefs.SetInt ("Rock", tempRock);
				PlayerPrefs.SetInt ("Wood", PlayerPrefs.GetInt ("Wood", 0) - 1);
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
				
				AllowCraft = false;
                SceneManager.LoadScene("InventoryTRUE");
				
			}
		}
	}
}
