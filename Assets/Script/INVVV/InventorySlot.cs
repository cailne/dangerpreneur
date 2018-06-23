using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

	public Image icon;
	public Button removeButton;
	MsItem item;

	public int staticTest;
	
	public void AddItem(MsItem newItem){
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
	}

	public void ClearSlot(){
		item = null;

		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;
	}

	public void OnRemoveButton(){
		Inventory.instance.Remove(item);
	}

	public void Selling(){
		if (item != null){
			staticTest += (int)(item.value * PlayerPrefs.GetFloat("ShopMM"));
			Inventory.instance.Remove(item);
		}
	}
}
