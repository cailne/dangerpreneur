using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	[SerializeField] ItemTooltip tooltip;
	public Image icon;
	public Button removeButton;
	MsItem item;

	
	protected virtual void OnValidate(){
		if (tooltip == null){
			tooltip = FindObjectOfType<ItemTooltip>();
		}
	}

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

    public void OnPointerEnter(PointerEventData eventData)
    {
		if (item != null)
        	tooltip.ShowTooltip(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.HideTooltip();
    }

    public void OnRemoveButton(){
		Inventory.instance.Remove(item);
	}

	public void Selling(){
		if (item != null){
			MoneyScript.defaultMoney += (int)(item.value * PlayerPrefs.GetFloat("ShopMM"));
			Inventory.instance.Remove(item);
		}
	}
}
