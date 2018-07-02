using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public Text Restarting;
	public Text HighScoreT;
	private int highschore;
	float counter = 5f;


	void Awake() {
		if (PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) > PlayerPrefs.GetInt ("HighScore", 0)) {
			highschore = PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney);
			PlayerPrefs.SetInt ("HighScore", highschore);
		}

		HighScoreT.text = "Your Score : " + PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) + "" +
			"\nHigh Score : " + PlayerPrefs.GetInt ("HighScore", 0);
	}
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
		PlayerPrefs.SetInt ("HighScore", highschore);
		SceneManager.LoadScene("MainMenu");

	}

}
