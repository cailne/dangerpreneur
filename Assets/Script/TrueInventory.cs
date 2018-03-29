using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueInventory : MonoBehaviour {

	GameObject inventoryPanel;
    GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();
}
