using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmployeeManager : MonoBehaviour {
	public Text EmployeeCopper, EmployeeGold, EmployeeIron, EmployeeSilver, EmployeeRock, EmployeeWood;
	//TEXT YANG NGE DISPLAY BONUS DARI EMPLOYEE
	private int BonusCopper, BonusGold, BonusIron, BonusSilver, BonusRock, BonusWood; 
	//VALUE BONUS NYA, DAPET DARI GET INT DARI HIRE

	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;


	public float GenerateTime; //waktu yang dibutuhkan buat karyawan nge generate resource
	private float counter; 


	void Start () {
		BonusCopper = PlayerPrefs.GetInt ("BonusCopper", 0);
		BonusGold = PlayerPrefs.GetInt ("BonusGold", 0);
		BonusIron = PlayerPrefs.GetInt ("BonusIron", 0);
		BonusSilver = PlayerPrefs.GetInt ("BonusSilver", 0);
		BonusRock = PlayerPrefs.GetInt ("BonusRock", 0);
		BonusWood = PlayerPrefs.GetInt ("BonusWood", 0);
	}
	

	void Update () {
		Debug.Log (BonusCopper);

		tempCooper = PlayerPrefs.GetInt ("Cooper", 0);
		tempGold = PlayerPrefs.GetInt ("Gold", 0);
		tempIron = PlayerPrefs.GetInt ("Iron", 0);
		tempRock = PlayerPrefs.GetInt ("Rock", 0);
		tempSilver = PlayerPrefs.GetInt ("Silver", 0);
		tempWood = PlayerPrefs.GetInt ("Wood", 0);

		EmployeeCopper.text = "+ " + BonusCopper.ToString ();
		EmployeeGold.text = "+ " + BonusGold.ToString ();
		EmployeeIron.text = "+ " + BonusIron.ToString ();
		EmployeeSilver.text = "+ " + BonusSilver.ToString ();
		EmployeeRock.text = "+ " + BonusRock.ToString ();
		EmployeeWood.text = "+ " + BonusWood.ToString ();


		//HIRE AND EMPLOYEE
		if (BonusCopper != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempCooper += BonusCopper;
				PlayerPrefs.SetInt ("Cooper", tempCooper);
				counter = 0;
			}
		}

		if (BonusGold != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempGold += BonusGold;
				PlayerPrefs.SetInt ("Gold", tempGold);
				counter = 0;
			}
		}

		if (BonusIron != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempIron += BonusIron;
				PlayerPrefs.SetInt ("Iron", tempIron);
				counter = 0;
			}
		}

		if (BonusSilver != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempSilver += BonusSilver;
				PlayerPrefs.SetInt ("Silver", tempSilver);
				counter = 0;
			}
		}

		if (BonusRock != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempRock += BonusRock;
				PlayerPrefs.SetInt ("Rock", tempRock);
				counter = 0;
			}
		}

		if (BonusWood != 0) {
			counter += Time.deltaTime;
			if (counter >= GenerateTime) {
				tempWood += BonusWood;
				PlayerPrefs.SetInt ("Wood", tempWood);
				counter = 0;
			}
		}
	}
}
