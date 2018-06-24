using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTab : MonoBehaviour {

	//Selected tabs
	public GameObject TabBuy; 
	public GameObject TabHire;
	public GameObject TabSell;

	//Unselected tabs
	public GameObject UnselectBuy, UnselectHire, UnselectSell;

	void Start() {
		ChangeToBuy ();

	}

	public void ChangeToBuy(){
		TabHire.SetActive (false);
		TabSell.SetActive (false);
		TabBuy.SetActive (true);

		UnselectBuy.SetActive (false);
		UnselectHire.SetActive (true);
		UnselectSell.SetActive (true);
	}

	public void ChangeToHire(){
		TabBuy.SetActive (false);
		TabSell.SetActive (false);
		TabHire.SetActive (true);

		UnselectBuy.SetActive (true);
		UnselectHire.SetActive (false);
		UnselectSell.SetActive (true);
	}

	public void ChangeToSell(){
		TabBuy.SetActive (false);
		TabHire.SetActive (false);
		TabSell.SetActive (true);

		UnselectBuy.SetActive (true);
		UnselectHire.SetActive (true);
		UnselectSell.SetActive (false);
	}

}
