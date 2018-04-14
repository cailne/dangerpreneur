using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterSceneChange : MonoBehaviour {
	public void ToCrafting(){
		SceneManager.LoadScene("Crafting");
	}
	public void ToCrafting2Complete(){
		SceneManager.LoadScene("Crafting2Complete");
	}
	public void ToInv(){
		SceneManager.LoadScene("Inv");
	}
	public void ToGameplay(){
		SceneManager.LoadScene("S1");
	}

	public void ToBlackMarket() {
		SceneManager.LoadScene ("BlackMarket");
	}
}
