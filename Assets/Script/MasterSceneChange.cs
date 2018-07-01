using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MasterSceneChange : MonoBehaviour {

	//public Timer t;

	public AudioClip ClickSound;
	public AudioClip BackButtonSound;
	public AudioClip BlackMarketSound;
	public AudioClip BuySound;
	public AudioClip BGMusic;

	/*public static MasterSceneChange MSC;

	private void Awake()
	{
		if(MSC == null)
		{
			MSC = this;
			DontDestroyOnLoad(gameObject);
		}else
		{
			Destroy(gameObject);
		}
	}*/

	void Start() {
		if (SceneManager.GetActiveScene ().name == "BlackMarket") {
			StartCoroutine (WaitBlackMarketSound ());
		} else {
			BackMusic.instance.PlayMusic (BGMusic);
		}


	}

	public void ToGameplay(){
		SFX.instance.source.PlayOneShot (BackButtonSound);
		SceneManager.LoadScene("S1");
	}
	public void ToCrafting(){
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene("Crafting");
	}
	public void ToCrafting2Complete(){
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene("Crafting2Complete");
	}
	public void ToInv(){
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene("InventoryTRUE");
	}

	public void ExitGame() {
		//MASUKKIN PLAYER PREF SIMPEN DATABASE DISINI
		//SFX.instance.source.PlayOneShot (ClickSound);
		Application.Quit();
	}

	public void ToMainMenu() {
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene ("MainMenu");
	}

	public void ToBlackMarket() {
		//SFX.instance.source.PlayOneShot (BackButtonSound);
		SceneManager.LoadScene ("BlackMarket");
	}

	public void ToShop() {
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene ("Shop");
	}

	public void ToSellingConfirmation(){
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene("Selling");
	}


	public void ToCraftingFromS1(){
		SceneManager.LoadScene("Crafting");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}
	public void ToInvFromS1(){
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene("Inv");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}
	

	public void ToBlackMarketFromS1() {
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene ("BlackMarket");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}

	public void ToShopFromS1() {
		//SFX.instance.source.PlayOneShot (ClickSound);
		SceneManager.LoadScene ("Shop");
		//float g = t.TrueTime;
		//PlayerPrefs.SetFloat("Time",g);
	}

	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			SFX.instance.source.PlayOneShot (ClickSound);
		}
	}

	IEnumerator WaitBlackMarketSound() {
		BackMusic.instance.source.Stop ();
		SFX.instance.source.PlayOneShot (BlackMarketSound);
		yield return new WaitForSeconds (5f);
		BackMusic.instance.PlayMusic (BGMusic);
	}
}
