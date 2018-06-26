using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	
	#region Singleton

	public static Inventory instance { get; private set; }

	void Awake(){
		if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
		}
	    else
        {
            Destroy(gameObject);
        }
	}

    #endregion

    void Start()
    {
        
    }

    public delegate void OnItemChanged();
	public OnItemChanged onItemChangeCallback;

	public int space = 15;

	public List<MsItem> items = new List<MsItem>();

	public bool Add(MsItem item){
		if(!item.isDefaultItem){
			if (items.Count >= space){
				Debug.Log("not enough");
				return false;
			}
			items.Add(item);


			if (onItemChangeCallback != null)
				onItemChangeCallback.Invoke();
			
		}
		return true;
	}

	public void Remove(MsItem item){
		items.Remove(item);
		if (onItemChangeCallback != null)
			onItemChangeCallback.Invoke();
	}
}
