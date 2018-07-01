using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MasterSceneChange : MonoBehaviour {

	//public Timer t;

	public void ToGameplay(){
		SceneManager.LoadScene("S1");
	}
	public void ToCrafting(){
		SceneManager.LoadScene("Crafting");
	}
	public void ToCrafting2Complete(){
		SceneManager.LoadScene("Crafting2Complete");
	}
	public void ToInv(){
		SceneManager.LoadScene("InventoryTRUE");
	}
	

	public void ToBlackMarket() {
		SceneManager.LoadScene ("BlackMarket");
	}

	public void ToShop() {
		SceneManager.LoadScene ("Shop");
	}

	public void ToSellingConfirmation(){
		SceneManager.LoadScene("Selling");
	}


	public void ToCraftingFromS1(){
		SceneManager.LoadScene("Crafting");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}
	public void ToInvFromS1(){
		SceneManager.LoadScene("Inv");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}
	

	public void ToBlackMarketFromS1() {
		SceneManager.LoadScene ("BlackMarket");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}

	public void ToShopFromS1() {
		SceneManager.LoadScene ("Shop");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}
}
