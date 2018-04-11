using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class Craft : MonoBehaviour {
	private string jsonString;
	private JsonData invSaving;
	private JsonData invData;
	ItemToInv var;

	public List<ItemBase> item = new List<ItemBase>();

	void Start(){
		jsonString = File.ReadAllText(Application.dataPath + "/DATABASE/Inventory.json");
		invData = JsonMapper.ToObject(jsonString);
	}

	public void MakeWeapon(){
		/*PersistentVariables.i.lethality = item[4].Lethality + Random.Range (15, 30);
		PersistentVariables.i.durability = item[4].Durability + Random.Range (15, 30);
		PersistentVariables.i.weight = item[4].Weight + Random.Range (15, 30);
		PersistentVariables.i.cost = item[4].Cost + Random.Range (15, 30);

		for (int i = 0;i < invData.Count;i++){
			if ((bool)invData[i]["Available"]){
				var = new ItemToInv(i, false, 4, item[4].Title, PersistentVariables.i.lethality, PersistentVariables.i.durability,
				PersistentVariables.i.weight, PersistentVariables.i.cost, item[4].Slug, item[4].Stackable, item[4].Description);
				break;
			}
		}

		invSaving = JsonMapper.ToJson(var);
		File.WriteAllText(Application.dataPath + "/DATABASE/Inventory.json", invSaving.ToString());*/

		PlayerPrefs.SetInt("craft", 1);
	}

	public class ItemToInv {
		public int SlotID {get; set;}
		bool Available {get; set;}
		public int ID {get; set;}
		public string Title {get; set;}
		public int Lethality {get; set;}
		public int Durability {get; set;}
		public int Weight {get; set;}
		public int Cost {get; set;}
		public string Slug {get; set;}
		public bool Stackable {get; set;}
		public string Description {get; set;}

		public ItemToInv(int slotid, bool available, int id, string title, int lethality, int durability, int weight, int cost, 
					string slug, bool stackable, string description){
			this.SlotID = slotid;
			this.Available = available;
			this.ID = id;
			this.Title = title;
			this.Lethality = lethality;
			this.Durability = durability;
			this.Weight = weight;
			this.Cost = cost;
			this.Slug = slug; //CALLING THE SPRITES
			this.Stackable = stackable;
			this.Description = description;
			//this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug); //THIS CAN DO MORE THAN ONE SPRITE, I GUESS
		}
	}

	
}
