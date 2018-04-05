using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {
  
    private TrueInventory inv;

    void Start(){
        inv = GameObject.Find("Inv Script").GetComponent<TrueInventory>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        ItemData droppedItem = eventData.pointerDrag.GetComponent<ItemData>();
        
    }

}
