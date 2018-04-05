using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {
	private Item item;
	private string data;
	private GameObject tooltip;

	void Start(){
		//define variables
		tooltip = GameObject.Find("Tooltip");
		tooltip.SetActive(false); //disappear at first launch
	}

	void Update(){
		if (tooltip.activeSelf){ //if the tooltip is active
			tooltip.transform.position = Input.mousePosition; //set the position near the cursor
		}
	}

	public void Activate(Item item){
		this.item = item; //get the item's data
		ConstructDataString(); //construct the string for tooltip
		tooltip.SetActive(true); //appear!
	}

	public void Deactivate(){
		tooltip.SetActive(false); //disappear!
	}


	public void ConstructDataString(){
		//the string for tooltip
		data = item.Title + "\n\n\n" + item.Description; //THIS CAN DO HTML FORMATTING TEXT
		tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
	}
}
