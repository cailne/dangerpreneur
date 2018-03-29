using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyScript : MonoBehaviour {

	public Slider EnergySlider;
	public Text TextEnergy;
	public float TimeToRecharge;

	public static int CurrEnergy;
	float counter;


	private void Start() {
		CurrEnergy = 10;
		EnergySlider.value = 0f;
		counter = 0;
	}

	void Update() {
		if (CurrEnergy != 10) {
			EnergySlider.value = counter / TimeToRecharge;
		} else {
			EnergySlider.value = 1;
		}


		if (CurrEnergy < 10) {
			counter += Time.deltaTime;

			if (counter >= TimeToRecharge) {
				CurrEnergy++;
				counter = 0;
			} 

		} /*else {
			counter = TimeToRecharge;
		}*/



		/*if (CurrEnergy <= 10) { //Max energy = 10
			counter += Time.deltaTime; //counter ditambah per detik
			EnergySlider.value = counter / TimeToRecharge; //slidernya nambah berdasarkan waktu counter
			//EnergySlider.value = (CurrEnergy + counter) / (TimeToRecharge * 10);
			Debug.Log(counter);
			if (counter >= TimeToRecharge && CurrEnergy + 1 <= 10) { //Kalau udah sampe TimeToRecharge (10 detik), counternya
																	 //kereset jadi 0 lagi dan current energynya nambah
				counter = 0;
				CurrEnergy++;
			} else {
				counter = TimeToRecharge;
			}

		}*/

		TextEnergy.text = "Energy : " + CurrEnergy + " / 10";
	}
}
