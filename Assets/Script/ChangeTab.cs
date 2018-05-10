using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTab : MonoBehaviour {
	public GameObject TabBuy;
	public GameObject TabHire;
	public GameObject TabSell;

	public void ChangeToBuy(){
		TabHire.SetActive (false);
		TabSell.SetActive (false);
		TabBuy.SetActive (true);
	}

	public void ChangeToHire(){
		TabBuy.SetActive (false);
		TabSell.SetActive (false);
		TabHire.SetActive (true);
	}

	public void ChangeToSell(){
		TabBuy.SetActive (false);
		TabHire.SetActive (false);
		TabSell.SetActive (true);
	}

}
