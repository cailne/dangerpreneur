using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueInventory : MonoBehaviour {

	GameObject inventoryPanel;
    GameObject slotPanel;
    InventoryDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    void Start(){
        //define variables
        database = GetComponent<InventoryDatabase>();

        //slotAmount means the inventory slot
        slotAmount = 15;
        //define variables
        inventoryPanel = GameObject.Find("Inventory Panel");
        slotPanel = inventoryPanel.transform.Find("Slot Panel").gameObject;
        //contruct inventory
        for (int i = 0; i < slotAmount; i++){
            items.Add(new Item()); //add some null item, which is empty slot
            slots.Add(Instantiate(inventorySlot)); //cloning gameobject
            slots[i].GetComponent<Slot>().id = i; //define the id of the slot, 1,2,3 and so on
            slots[i].transform.SetParent(slotPanel.transform); //set the cloned slots's parent into slotpanel
            slots[i].transform.localScale = Vector3.one; //set the scale to 1, it gets bigger without it, idk
        }

        //AddItem(4);

        if(PlayerPrefs.GetInt("craft") > 0){
            AddItem(4);
        }
    }

    public void AddItem(int id){
        //we need to know what items is going to be added, therefore we can fetch it by items ID
        Item itemToAdd = database.FetchByID(id);

        //this checks if the item is stackable
        //which is useless, since the items is always different
        //just saved this for the future, not going to explain it
        /*if (itemToAdd.Stackable && CheckInvItemAvailable(itemToAdd)){
            for (int i = 0; i < items.Count; i++){
                if (items[i].ID == id){
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    break;
                }
            }
        }else{*/
            //this run if the item is not stackable
                //why using for? we're just going to add 1 item
                //well, we don't know where the empty slot is, so we search it by using for loop
                for (int i = 0; i < items.Count; i++){
                    if (items[i].ID == -1){ //this run if we know where the empty slot is
                        items[i] = itemToAdd; //the items in inventory is automatically replace by the original items data
                        GameObject itemObj = Instantiate(inventoryItem); //calling the items from prefab
                        //all of this going to update the ItemData script's variable
                        itemObj.GetComponent<ItemData>().item = itemToAdd;
                        itemObj.GetComponent<ItemData>().amount = 1; //it's 1, because we only add 1 item
                        itemObj.GetComponent<ItemData>().slot = i;
                        //===================================================================================
                        itemObj.transform.SetParent(slots[i].transform); //set the item's parent to inventory slot
                        itemObj.transform.position = Vector2.zero; //centering the item position with slot
                        itemObj.transform.localScale = Vector3.one;
                        //itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite; //calling the item sprite
                        //itemObj.name = itemToAdd.Title; //it renames gameobject in unity hierarchy, looks neat

                        break; //if we already add the item, break the loop!
                    }
                }
        //}
    }

    //this too is for stackable items, not going to explain it
    bool CheckInvItemAvailable(Item item){
        for (int i = 0;i < items.Count; i++){
            if (items[i].ID == item.ID)return true;
        }
        return false;
    }
}
