using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;

public class ShopMgr : MonoBehaviour {

	public string connectionPath;
	public Text ShowIron;
	public Text ShowCopper;
	public Text ShowSilver;
	public Text ShowGold;
	public Text ShowSteel;
	public Text ShowWood;
	public Text refreshTime;
	public Text ShowIPrice;
	public Text ShowCPrice;
	public Text ShowSPrice;
	public Text ShowGPrice;
	public Text ShowStPrice;
	public Text ShowWPrice;
	public int Iron;
	public int Copper;
	public int Silver;
	public int Gold;
	public int Steel;
	public int Wood;
	public int IronPrice;
	public int CopperPrice;
	public int SilverPrice;
	public int GoldPrice;
	public int SteelPrice;
	public int WoodPrice;
	int BaseIronPrice;
	int BaseCopperPrice;
	int BaseSilverPrice;
	int BaseGoldPrice;
	int BaseSteelPrice;
	int BaseWoodPrice;
	float timeRemaining;

	void Awake(){
		connectionPath = "URI=file:" + Application.dataPath + "/Dangerpreneur.sqlite";
		ReadDBResource ();
		ReadDBPrice ();
	}
	// Use this for initialization
	void Start () {
		ShowStock ();
		ShowPrice ();
		timeRemaining = 5;
		StockRandomizer ();
		PriceRandomizer ();
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
		ShowStock ();
		ShowPrice ();
		//Debug.Log ("Current price of iron is : " + IronPrice);
	}

	void ReadDBResource(){
		using(IDbConnection dbConnection = new SqliteConnection(connectionPath)){
			dbConnection.Open();

			using(IDbCommand dbCmd = dbConnection.CreateCommand()){
				string SQLQuery = "SELECT Iron,Copper,Silver,Gold,Steel,Wood FROM ShopResourceSupplies";

				dbCmd.CommandText = SQLQuery;

				using(IDataReader reader = dbCmd.ExecuteReader()){

					while (reader.Read ()) {
						Debug.Log ("Iron : " + reader.GetInt16(0));
						Debug.Log ("Copper : " + reader.GetInt16(1));
						Debug.Log ("Silver : " + reader.GetInt16(2));
						Debug.Log ("Gold : " + reader.GetInt16(3));
						Debug.Log ("Steel : " + reader.GetInt16(4));
						Debug.Log ("Wood : " + reader.GetInt16(5));
						Iron = reader.GetInt16(0);
						Copper = reader.GetInt16 (1);
						Silver = reader.GetInt16 (2);
						Gold = reader.GetInt16 (3);
						Steel = reader.GetInt16 (4);
						Wood = reader.GetInt16 (5);
					}

					dbConnection.Close ();
					reader.Close ();
				}
			}
		}
	}

	void ReadDBPrice(){
		using(IDbConnection dbConnection = new SqliteConnection(connectionPath)){
			dbConnection.Open();

			using(IDbCommand dbCmd = dbConnection.CreateCommand()){
				string SQLQuery = "SELECT IronPrice,CopperPrice,SilverPrice,GoldPrice,SteelPrice,WoodPrice FROM ResourcePrice";

				dbCmd.CommandText = SQLQuery;

				using(IDataReader reader = dbCmd.ExecuteReader()){

					while (reader.Read ()) {
						Debug.Log ("IronPrice : " + reader.GetInt16(0));
						Debug.Log ("CopperPrice : " + reader.GetInt16(1));
						Debug.Log ("SilverPrice : " + reader.GetInt16(2));
						Debug.Log ("GoldPrice : " + reader.GetInt16(3));
						Debug.Log ("SteelPrice : " + reader.GetInt16(4));
						Debug.Log ("WoodPrice : " + reader.GetInt16(5));
						IronPrice = reader.GetInt16(0);
						CopperPrice = reader.GetInt16 (1);
						SilverPrice = reader.GetInt16 (2);
						GoldPrice = reader.GetInt16 (3);
						SteelPrice = reader.GetInt16 (4);
						WoodPrice = reader.GetInt16 (5);
						BaseIronPrice = reader.GetInt16(0);
						BaseCopperPrice = reader.GetInt16(1);
						BaseSilverPrice = reader.GetInt16(2);
						BaseGoldPrice = reader.GetInt16(3);
						BaseSteelPrice = reader.GetInt16(4);
						BaseWoodPrice = reader.GetInt16(5);
					}

					dbConnection.Close ();
					reader.Close ();
				}
			}
		}
	}

	void StockRandomizer(){
		Iron = UnityEngine.Random.Range(1,25);
		Copper = UnityEngine.Random.Range(1,25);
		Silver = UnityEngine.Random.Range(1,25);
		Gold = UnityEngine.Random.Range(1,25);
		Steel = UnityEngine.Random.Range(1,25);
		Wood = UnityEngine.Random.Range(1,25);
	}

	void PriceRandomizer(){
		IronPrice = BaseIronPrice * UnityEngine.Random.Range(1,4);
		CopperPrice = BaseCopperPrice * UnityEngine.Random.Range(1,4);
		SilverPrice = BaseSilverPrice * UnityEngine.Random.Range(1,4);
		GoldPrice = BaseGoldPrice * UnityEngine.Random.Range(1,4);
		SteelPrice = BaseSteelPrice * UnityEngine.Random.Range(1,4);
		WoodPrice = BaseWoodPrice * UnityEngine.Random.Range(1,4);
	}

	void ShowStock(){
		ShowIron.text = "Iron : " + Iron;
		ShowCopper.text = "Copper : " + Copper;
		ShowSilver.text = "Silver : " + Silver;
		ShowGold.text = "Gold : " + Gold;
		ShowSteel.text = "Steel : " + Steel;
		ShowWood.text = "Wood : " + Wood;
	}

	void ShowPrice(){
		ShowIPrice.text = "Price : " + IronPrice;
		ShowCPrice.text = "Price : " + CopperPrice;
		ShowSPrice.text = "Price : " + SilverPrice;
		ShowGPrice.text = "Price : " + GoldPrice;
		ShowStPrice.text = "Price : " + SteelPrice;
		ShowWPrice.text = "Price : " + WoodPrice;
	}

	private void OnGUI(){
		if (timeRemaining > 0) {
			refreshTime.text = "Restock in : " + (int)timeRemaining;
		} else {
			Start ();
		}
	}
}
