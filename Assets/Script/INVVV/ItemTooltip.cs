using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour {

	[SerializeField] Text ItemName;
	[SerializeField] Text ItemValue;
	[SerializeField] Image ItemIcon;

	public void ShowTooltip(MsItem item){
		ItemName.text = item.name;
		ItemValue.text = "Price: " + item.value.ToString();
		ItemIcon.sprite = item.icon;
		gameObject.SetActive(true);
	}

	public void HideTooltip(){
		gameObject.SetActive(false);
	}
}
