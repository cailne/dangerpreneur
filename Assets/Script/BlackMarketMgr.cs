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


	// Use this for initialization
	void Start () {
		connectionPath = "URI=file:" + Application.dataPath + "/Dangerpreneur.sqlite";
		GetWeaponName ();
		ShowRequest ();
	}
	
	// Update is called once per frame
	void Update () {
		
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
	}
}
