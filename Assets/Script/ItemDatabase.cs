using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using LitJson;

public class ItemDatabase : MonoBehaviour {
	private List<Item> database = new List<Item>();
	private JsonData itemData;

	void Start(){
		//define the variables and construct database
		itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/DATABASE/Items.json"));
		ConstructDatabase();
	}

	public Item FetchByID(int id){
		//linear search for item ID in entire inventory
		for(int i = 0; i<database.Count; i++){
			if (database[i].ID == id)
				return database[i];
		}
		return null; //if not found
	}

	void ConstructDatabase(){
		//construct all of the base status from database
		for(int i=0;i<itemData.Count; i++){
			database.Add(new Item((int)itemData[i]["id"], itemData[i]["title"].ToString(),
			(int)itemData[i]["stats"]["lethality"], (int)itemData[i]["stats"]["durability"],
			(int)itemData[i]["stats"]["weight"], (int)itemData[i]["stats"]["cost"],
			itemData[i]["slug"].ToString(), (bool)itemData[i]["stackable"],
			itemData[i]["description"].ToString()));
		}
	}

	
	
}

public class Item
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
		public Item(int id, string title, int lethality, int durability, int weight, int cost, 
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
		public Item(){
			this.ID = -1;
		}
		//===================================================================================
	}