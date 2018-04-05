using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, 
						IPointerEnterHandler, IPointerExitHandler{

	public Item item;
	public int amount;
	public int slot;


	private TrueInventory inv;
	private Tooltip tooltip;
	private Vector2 offset;

	void Start(){
		//define variables
		inv = GameObject.Find("Inv Script").GetComponent<TrueInventory>();
		tooltip = inv.GetComponent<Tooltip>();
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
		//when we want to start dragging an item, we have to know the players is dragging empty object or not
        if (item != null){
			//this just some 'math' formula for 'dragging aesthetics', don't mind it
			offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
			//why we set the parent into slotPanel?
			//because when you start dragging it, the item comes behind another slot than his parent slot
			//therefore we set the parent to slotPanel, which is the parent of all slot
			this.transform.SetParent(this.transform.parent.parent);
			//when you drag the item, it is obvious the item should follow the cursor
			this.transform.position = eventData.position - offset;
			//this disable the 'hitbox' of the gameobject, why we disable it?
			//its because we can't detect the position of the cursor, since it's blocked by the item we dragged
			GetComponent<CanvasGroup>().blocksRaycasts = false;
		}
    }

    public void OnDrag(PointerEventData eventData)
    {
		//when you drag the item, it is obvious the item should follow the cursor
        if (item != null){
			this.transform.position = eventData.position - offset; //or minus offset
		}
    }

    public void OnEndDrag(PointerEventData eventData)
    {
		//when you already done dragging the item to another inventory slot
		//we have to set the item's parent back to slot, not slotPanel
        this.transform.SetParent(inv.slots[slot].transform);
		//still the same, centering the position
		this.transform.position = inv.slots[slot].transform.position;
		//enable the raycast back
		GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
		//this just some 'dragging aesthetics', don't mind it
        if (item != null){
			offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
		}
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
		//this is for tooltip, when cursor enter the raycast of an item, the tooltip will appear
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
		//this is for tooltip, when cursor exit the raycast of an item, the tooltip wil disappear
        tooltip.Deactivate();
    }
}
