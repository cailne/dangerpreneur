using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddInventory : MonoBehaviour {

	public Text inventory;

	public int cooper, gold, iron, rock, silver, wood;

	public Text cooperText, goldText, ironText, rockText, silverText, woodText;

	float timer;

	private void Start() {
		cooper = 0;
		gold = 0;
		iron = 0;
		rock = 0;
		silver = 0;
		wood = 0;

		timer = 0f;
	}

	//Singleton
	public static AddInventory instance;
	private void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}


	void Update () {
		inventory.text = "Inventory :\n\nCooper : " + cooper + "\nGold : " + gold + " \nIron : " + iron + "\nRock : " + rock + "\nSilver : " + silver + "\nWood : " + wood;

		if (cooperText != null && goldText != null && ironText != null && rockText != null && silverText != null & woodText != null) {
			if(cooperText.gameObject.activeInHierarchy == true) {
				Debug.Log ("Cooper text is true");
				//timer = 0;
				timer += Time.deltaTime;
				Debug.Log (timer);
				if (timer >= 1f) {
					cooperText.gameObject.SetActive (false);
					timer = 0f;
				}


			}

			if(goldText.gameObject.activeInHierarchy == true) {
				//Debug.Log ("Gold text is true");

				timer += Time.deltaTime;
				//Debug.Log (timer);
				if (timer >= 1f) {
					goldText.gameObject.SetActive (false);
					timer = 0f;
				}

			}

			if(ironText.gameObject.activeInHierarchy == true) {

				timer += Time.deltaTime;
				if (timer >= 1f) {
					ironText.gameObject.SetActive (false);
					timer = 0f;
				}

			}

			if(rockText.gameObject.activeInHierarchy == true) {

				timer += Time.deltaTime;
				if (timer >= 1f) {
					rockText.gameObject.SetActive (false);
					timer = 0f;
				}

			}

			if(silverText.gameObject.activeInHierarchy == true) {

				timer += Time.deltaTime;
				if (timer >= 1f) {
					silverText.gameObject.SetActive (false);
					timer = 0f;
				}

			}

			if(woodText.gameObject.activeInHierarchy == true) {

				timer += Time.deltaTime;
				if (timer >= 1f) {
					woodText.gameObject.SetActive (false);
					timer = 0f;
				}
		}

		}
	
	}
}
