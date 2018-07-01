using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour {

	[SerializeField] Text ItemName;
	[SerializeField] Text ItemValue;
	//[SerializeField] Image ItemIcon;

	public GameObject tooltip;

	void Update(){
		if (tooltip.activeSelf){ //if the tooltip is active
			tooltip.transform.position = Input.mousePosition; //set the position near the cursor
		}
	}

	public void ShowTooltip(MsItem item){
		ItemName.text = item.name;
		//ItemIcon.sprite = item.icon;
		gameObject.SetActive(true);
	}

	public void HideTooltip(){
		gameObject.SetActive(false);
	}
}
