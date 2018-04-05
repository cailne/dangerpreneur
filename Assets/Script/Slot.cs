using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {
  
    public int id;
    private TrueInventory inv;

    void Start(){
        //define variables
        inv = GameObject.Find("Inv Script").GetComponent<TrueInventory>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        //this declares what is the dropped item after being dragged
        ItemData droppedItem = eventData.pointerDrag.GetComponent<ItemData>();
        //if the slot is empty
        if (inv.items[id].ID == -1){
            inv.items[droppedItem.slot] = new Item(); //the old item slot becomes empty
            inv.items[id] = droppedItem.item; //update new inventory slot to the item we dragged
            droppedItem.slot = id; //updating the item's slot ID
        //if the slot isn't empty, it will swap the item
        }else if (droppedItem.slot != id){
            //this is the item which position is going to be changed to item we dragged before
            Transform item = this.transform.GetChild(0);
            item.GetComponent<ItemData>().slot = droppedItem.slot; //change item's slot to dragged item's slot
            item.transform.SetParent(inv.slots[droppedItem.slot].transform); //set item's parent to dragged item's parent
            //set item's position to dragged item's position
            item.transform.position = inv.slots[droppedItem.slot].transform.position;

            //change all of the dragged item's info to item's info
            droppedItem.slot = id; //slot ID
            droppedItem.transform.SetParent(this.transform); //parent
            droppedItem.transform.position = this.transform.position; //position

            //change all of the item's data
            inv.items[droppedItem.slot] = item.GetComponent<ItemData>().item;
            inv.items[id] = droppedItem.item;
        }
    }

}
