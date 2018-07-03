using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;


public class BlackMarketMgr : MonoBehaviour {

	private string connectionPath;

	//public GameObject ReqPrefab;

	public string Request;

	public Text PersonRequest;
	public Text AfterSell;

	float timeRemaining;
	int idx;
	Selling selling;

	// Use this for initialization

	void Awake(){
		connectionPath = "URI=file:" + Application.dataPath + "/StreamingAssets/Dangerpreneur.sqlite";
		AfterSell.gameObject.SetActive (false);
	}
	void Start () {
		timeRemaining = 5;
		GetWeaponName ();
		ShowRequest ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeRemaining > 0) {
			timeRemaining -= Time.deltaTime;
		} else {
			Start ();
		}
	}

	public void SellBlackMarket() {
		if (Inventory.Item [idx] >= 1) {
			Inventory.Item [idx] -= 1;
			PlayerPrefs.SetInt ("Money", PlayerPrefs.GetInt ("Money", MoneyScript.defaultMoney) + (int)selling.GetPrice (idx));
			AfterSell.gameObject.SetActive (true);
			AfterSell.text = "Success!";
		} else {
			AfterSell.gameObject.SetActive (true);
			AfterSell.text = "You don't have that item!";
		}
	}
	private void GetWeaponName(){
		using(IDbConnection dbConnection = new SqliteConnection(connectionPath)){
			dbConnection.Open();

			using(IDbCommand dbCmd = dbConnection.CreateCommand()){
				string SQLQuery = "SELECT WeaponName FROM BlackMarket ORDER BY ROUND(RANDOM()*(19-1+1)+1-0.5,0) LIMIT 1";

				dbCmd.CommandText = SQLQuery;

				using(IDataReader reader = dbCmd.ExecuteReader()){

					while (reader.Read ()) {
						Debug.Log (reader.GetString(0));
						Request = reader.GetString(0);
					}

					dbConnection.Close ();
					reader.Close ();
				}
			}
		}
	}

	private void ShowRequest(){
		int Gold = UnityEngine.Random.Range (1000, 3001);
		string Speech = "Make me " + Request + " and i will give you " + Gold + " Rupiah";
		PersonRequest.text = Speech;
		AfterSell.gameObject.SetActive (false);
	}

	void StringToIdx() {
		if (Request == "Siwar Panjang Copper") {
			idx = 5;
		}else if (Request == "Siwar Panjang Gold") {
			idx = 6;
		}else if (Request == "Siwar Panjang Iron") {
			idx = 7;
		}else if (Request == "Siwar Panjang Silver") {
			idx = 8;
		}else if (Request == "Siwar Panjang Steel") {
			idx = 9;
		}

		if (Request == "Pedang Jenawi Copper") {
			idx = 0;
		}else if (Request == "Pedang Jenawi Gold") {
			idx = 1;
		}else if (Request == "Pedang Jenawi Iron") {
			idx = 2;
		}else if (Request == "Pedang Jenawi Silver") {
			idx = 3;
		}else if (Request == "Pedang Jenawi Steel") {
			idx = 4;
		}

		if (Request == "Tombak Trisula Copper") {
			idx = 10;
		} else if (Request == "Tombak Trisula Gold") {
			idx = 11;
		}else if (Request == "Tombak Trisula Iron") {
			idx = 12;
		}else if (Request == "Tombak Trisula Silver") {
			idx = 13;
		}else if (Request == "Tombak Trisula Steel") {
			idx = 14;
		}





	}
		
}
