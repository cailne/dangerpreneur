using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selling : MonoBehaviour {

	// Use this for initialization
	[SerializeField] float[] price;
	public Text pop;

	public float GetPrice(int index) {
		return price [index];
	}

	public void STW0(){
		if (Inventory.Item[0] >= 1){
			pop.text = "+" + (price[0] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[0] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[0] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[0] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW1(){
		if (Inventory.Item[1] >= 1){
			pop.text = "+" + (price[1] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[1] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[1] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[1] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW2(){
		if (Inventory.Item[2] >= 1){
			pop.text = "+" + (price[2] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[2] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[2] * PlayerPrefs.GetFloat("ShopMM")));

			Inventory.Item[2] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW3(){
		if (Inventory.Item[3] >= 1){
			pop.text = "+" + (price[3] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[3] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[3] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[3] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW4(){
		if (Inventory.Item[4] >= 1){
			pop.text = "+" + (price[4] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[4] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[4] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[4] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW5(){
		if (Inventory.Item[5] >= 1){
			pop.text = "+" + (price[5] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[5] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[5] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[5] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW6(){
		if (Inventory.Item[6] >= 1){
			pop.text = "+" + (price[6] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[6] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[6] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[6] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW7(){
		if (Inventory.Item[7] >= 1){
			pop.text = "+" + (price[7] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[7] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[7] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[7] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW8(){
		if (Inventory.Item[8] >= 1){
			pop.text = "+" + (price[8] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[8] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[8] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[8] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW9(){
		if (Inventory.Item[9] >= 1){
			pop.text = "+" + (price[9] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[9] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[9] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[9] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW10(){
		if (Inventory.Item[10] >= 1){
			pop.text = "+" + (price[10] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[10] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[10] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[10] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW11(){
		if (Inventory.Item[11] >= 1){
			pop.text = "+" + (price[11] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[11] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[11] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[11] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW12(){
		if (Inventory.Item[12] >= 1){
			pop.text = "+" + (price[12] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[12] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[12] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[12] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW13(){
		if (Inventory.Item[13] >= 1){
			pop.text = "+" + (price[13] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[13] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[13] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[13] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW14(){
		if (Inventory.Item[14] >= 1){
			pop.text = "+" + (price[14] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[14] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[14] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[14] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW15(){
		if (Inventory.Item[15] >= 1){
			pop.text = "+" + (price[15] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[15] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[15] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[15] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW16(){
		if (Inventory.Item[16] >= 1){
			pop.text = "+" + (price[16] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[16] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[16] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[16] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW17(){
		if (Inventory.Item[17] >= 1){
			pop.text = "+" + (price[17] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[17] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[17] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[17] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW18(){
		if (Inventory.Item[18] >= 1){
			pop.text = "+" + (price[18] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[18] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[18] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[18] -= 1;
			StartCoroutine(PopUp());
		}
	}
	public void STW19(){
		if (Inventory.Item[19] >= 1){
			pop.text = "+" + (price[19] * PlayerPrefs.GetFloat("ShopMM")).ToString();
			//MoneyScript.defaultMoney += (int)(price[19] * PlayerPrefs.GetFloat("ShopMM"));
			PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", MoneyScript.defaultMoney) + (int)(price[19] * PlayerPrefs.GetFloat("ShopMM")));
			Inventory.Item[19] -= 1;
			StartCoroutine(PopUp());
		}
	}

	IEnumerator PopUp(){
		pop.gameObject.SetActive(true);
		yield return new WaitForSeconds(2f);
		pop.gameObject.SetActive(false);
	}
}
