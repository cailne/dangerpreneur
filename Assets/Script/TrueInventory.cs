using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueInventory : MonoBehaviour {

	GameObject inventoryPanel;
    GameObject slotPanel;
    ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    void Start(){
        database = GetComponent<ItemDatabase>();

        slotAmount = 15;
        inventoryPanel = GameObject.Find("Inventory Panel");
        slotPanel = inventoryPanel.transform.Find("Slot Panel").gameObject;
        for (int i = 0; i < slotAmount; i++){
            items.Add(new Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
            slots[i].transform.localScale = Vector3.one;
        }
    }

    public void AddItem(int id){
        Item itemToAdd = database.FetchByID(id);

        if (itemToAdd.Stackable && CheckInvItemAvailable(itemToAdd)){
            for (int i = 0; i < items.Count; i++){
                if (items[i].ID == id){
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    break;
                }
            }
        }else{
                for (int i = 0; i < items.Count; i++){
                    if (items[i].ID == -1){
                        items[i] = itemToAdd;
                        GameObject itemObj = Instantiate(inventoryItem);
                        itemObj.GetComponent<ItemData>().item = itemToAdd;
                        itemObj.GetComponent<ItemData>().slot = i;
                        itemObj.transform.SetParent(slots[i].transform);
                        itemObj.transform.position = Vector2.zero;
                        itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                        itemObj.name = itemToAdd.Title;

                        break;
                    }
                }
        }
    }

    bool CheckInvItemAvailable(Item item){
        for (int i = 0;i < items.Count; i++){
            if (items[i].ID == item.ID)return true;
        }
        return false;
    }
}
