using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;

public class SaveCompanyName : MonoBehaviour {

	private string connectionPath;

	public Button ConfirmName;

	public string CompanyName;

	public Text ShowName;

	public InputField Name;

	// Use this for initialization
	void Start () {
		connectionPath = "URI=file:" + Application.dataPath + "/Dangerpreneur.sqlite";
		ConfirmName.onClick.AddListener (ProcessText);
		ShowName.text = CompanyName + " Co.";
	}
	
	// Update is called once per frame
	void Update () {
		ShowName.text = CompanyName + " Co.";
	}

	void InsertName(string CompName){
		using(IDbConnection dbConnection = new SqliteConnection(connectionPath)){
			dbConnection.Open();

			using(IDbCommand dbCmd = dbConnection.CreateCommand()){
				string SQLQuery = String.Format("UPDATE CompanyName\nSET Name = \"{0}\" \nWHERE ID = '1'",CompName);

				dbCmd.CommandText = SQLQuery;
				Debug.Log (CompName + " DB");
				dbCmd.ExecuteScalar ();
				dbConnection.Close ();

			}
		}
	}

	void ProcessText(){
		CompanyName = Name.text;
		Debug.Log (CompanyName);
		InsertName (CompanyName);
	}
}
