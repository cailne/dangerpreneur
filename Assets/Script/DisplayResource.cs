using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResource : MonoBehaviour {

	private int tempCooper, tempGold, tempIron, tempRock, tempSilver, tempWood;
	public Text cooperT, goldT, ironT, rockT, silverT, woodT;

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
}
