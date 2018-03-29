using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using LitJson;

public class ItemDatabase : MonoBehaviour {
	private List<Item> database = new List<Item>();
	private JsonData itemData;

	void start(){
		itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/DATABASE/Items.json"));
		ConstructDatabase();


	}

	public Item FetchByID(int id){
		for(int i = 0; i<database.Count; i++){
			if (database[i].ID == id)
				return database[i];
		}
		return null;
	}

	void ConstructDatabase(){
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
		public int ID {get; set;}
		public string Title {get; set;}
		public int Lethality {get; set;}
		public int Durability {get; set;}
		public int Weight {get; set;}
		public int Cost {get; set;}
		public string Slug {get; set;}
		public bool Stackable {get; set;}
		public string Description {get; set;}

		public Item(int id, string title, int lethality, int durability, int weight, int cost, string slug, bool stackable, string description){
			this.ID = id;
			this.Title = title;
			this.Lethality = lethality;
			this.Durability = durability;
			this.Weight = weight;
			this.Cost = cost;
			this.Slug = slug;
			this.Stackable = stackable;
			this.Description = description;
		}

		public Item(){
			this.ID = -1;
		}
	}