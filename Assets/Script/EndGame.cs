using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public Text Restarting;

	float counter = 5f;

	void Start() {
		StartCoroutine (FinishAndRestart ());
	}

	IEnumerator FinishAndRestart() {
		Restarting.text = "Restarting in 5 seconds";
		yield return new WaitForSeconds(1f);
		Restarting.text = "Restarting in 4 seconds";
		yield return new WaitForSeconds(1f);
		Restarting.text = "Restarting in 3 seconds";
		yield return new WaitForSeconds(1f);
		Restarting.text = "Restarting in 2 seconds";
		yield return new WaitForSeconds(1f);
		Restarting.text = "Restarting in 1 seconds";
		yield return new WaitForSeconds(1f);

		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene("MainMenu");

	}

}
