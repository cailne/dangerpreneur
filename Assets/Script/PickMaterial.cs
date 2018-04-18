using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickMaterial : MonoBehaviour {

	public void ChooseCopper() {
		PlayerPrefs.SetInt ("MaterialID", 1); 
		SceneManager.LoadScene("Crafting2Complete");
	}

	public void ChooseGold() {
		PlayerPrefs.SetInt ("MaterialID", 2); 
		SceneManager.LoadScene("Crafting2Complete");
	}

	public void ChooseIron() {
		PlayerPrefs.SetInt ("MaterialID", 3); 
		SceneManager.LoadScene("Crafting2Complete");
	}

	public void ChooseSilver() {
		PlayerPrefs.SetInt ("MaterialID", 4); 
		SceneManager.LoadScene("Crafting2Complete");
	}

	public void ChooseRock() {
		PlayerPrefs.SetInt ("MaterialID", 5); 
		SceneManager.LoadScene("Crafting2Complete");
	}
}
