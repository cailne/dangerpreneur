﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;
	InventorySlot[] slots;

	Inventory inventory;

	void Start(){
		inventory = Inventory.instance;
		inventory.onItemChangeCallback += UpdateUI;

		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}

	void Update(){

	}

	void UpdateUI(){
		for (int i = 0; i<slots.Length; i++){
			if (i < inventory.items.Count){
				slots[i].AddItem(inventory.items[i]);
			}else{
				slots[i].ClearSlot();
			}
		}
	}
	
}
