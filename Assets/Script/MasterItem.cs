using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using LitJson;

public class MasterItem : MonoBehaviour {
	private List<ItemBase> ItemDatabase = new List<ItemBase>();
	private JsonData masterItemData;

	void Start(){
		//define the variables and construct ItemDatabase
		masterItemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/DATABASE/Items.json"));
		ConstructDatabase();
	}

	public ItemBase FetchByID(int id){
		//linear search for item ID in entire inventory
		for(int i = 0; i<ItemDatabase.Count; i++){
			if (ItemDatabase[i].ID == id)
				return ItemDatabase[i];
		}
		return null; //if not found
	}

	void ConstructDatabase(){
		//construct all of the base status from ItemDatabase
		for(int i=0;i<masterItemData.Count; i++){
			ItemDatabase.Add(new ItemBase((int)masterItemData[i]["id"], masterItemData[i]["title"].ToString(),
			(int)masterItemData[i]["stats"]["lethality"], (int)masterItemData[i]["stats"]["durability"],
			(int)masterItemData[i]["stats"]["weight"], (int)masterItemData[i]["stats"]["cost"],
			masterItemData[i]["slug"].ToString(), (bool)masterItemData[i]["stackable"],
			masterItemData[i]["description"].ToString()));
		}
	}

	
	
}

public class ItemBase
	{
		//===================================================================================
		//SETTER AND GETTER
		public int ID {get; set;}
		public string Title {get; set;}
		public int Lethality {get; set;}
		public int Durability {get; set;}
		public int Weight {get; set;}
		public int Cost {get; set;}
		public string Slug {get; set;}
		public bool Stackable {get; set;}
		public string Description {get; set;}
		public Sprite Sprite {get; set;}
		//===================================================================================

		//===================================================================================
		//DEFINE THE BASE STATUS IN THE DATABASE
		public ItemBase(int id, string title, int lethality, int durability, int weight, int cost, 
					string slug, bool stackable, string description){
			this.ID = id;
			this.Title = title;
			this.Lethality = lethality;
			this.Durability = durability;
			this.Weight = weight;
			this.Cost = cost;
			this.Slug = slug; //CALLING THE SPRITES
			this.Stackable = stackable;
			this.Description = description;
			this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug); //THIS CAN DO MORE THAN ONE SPRITE, I GUESS
		}

		//THIS IS FOR NULL ITEM
		public ItemBase(){
			this.ID = -1;
		}

		
		//===================================================================================
	}