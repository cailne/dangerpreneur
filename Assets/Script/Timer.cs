using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

//public PersistentVariables pv;
public Text month;
public Text year;
public static Timer instance;

private float timeCore;
//[HideInInspector]
public float TrueTime, ttm;


	void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);

		} else {
			Destroy (gameObject);
		}
	}

	void Start () {
		//PlayerPrefs.DeleteKey ("Time");
		TrueTime = PlayerPrefs.GetFloat ("Time", 0);
		if (SceneManager.GetActiveScene ().name != "S1") {
			month.gameObject.SetActive (false);
			year.gameObject.SetActive (false);
		}
		timeCore = Time.time;
		//PlayerPrefs.SetFloat("Time",0f);
		if(PlayerPrefs.GetFloat("Time") <= 0){
			ttm = 0;
		}else if (PlayerPrefs.GetFloat("Time") > 0){
			ttm = PlayerPrefs.GetFloat("Time");
		}
		//ttm = PlayerPrefs.GetFloat ("Time", 0);
		//TrueTime += ttm;
		//Debug.Log("True time at start = " + TrueTime);
	}
	void Update () {
		TrueTime += Time.deltaTime;
		Debug.Log("True time update = " + TrueTime);

		string m = ((int) (TrueTime / 10) % 13 + 1).ToString();
		string y = ((int) (TrueTime / 120) + 1600).ToString();

		month.text = m;
		year.text = y;

		PlayerPrefs.SetFloat("Time", TrueTime);
	}
}




